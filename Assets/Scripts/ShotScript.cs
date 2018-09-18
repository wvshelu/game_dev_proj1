using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotScript : MonoBehaviour {

    // 1 - Designer variables

    /// <summary>
    /// Damage inflicted
    /// </summary>
    public int damage = 1;

    /// <summary>
    /// Projectile damage player or enemies?
    /// </summary>
    public bool isEnemyShot = false;

    private int life;

    void Start()
    {
        // 2 - Limited time to live to avoid any leak
        //Destroy(gameObject, 5); // 20sec
        life = 100;
    }

    void Update()
    {
        if (life < 0) {
            Destroy(gameObject);
        }
        if (!FreezeTimeScript.GetFrozen()) {
            life--;
        }
    }

}
