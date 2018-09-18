using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedPoulpi : MonoBehaviour {

    private int life;
    public GameObject laser;
    private GameObject ownLaser;
	// Use this for initialization
	void Start () {
        life = 150;
	}
	
	// Update is called once per frame
	void Update () {
        if (SpawnerScript.GetSingleton().GetGameOver()) {
            if (ownLaser != null) {
                Destroy(ownLaser);
            }
            Destroy(gameObject);
            return;
        }
        if (!FreezeTimeScript.GetFrozen()) {
            
            if (life == 100)
            {
                ownLaser = Instantiate(laser, gameObject.transform.position + new Vector3(-15, 0, 0), 
                                          Quaternion.identity) as GameObject;
                life--;
            }
            else if (life < 0)
            {
                Destroy(gameObject);
            }
            else
            {
                life--;
            }
        }

    }
}
