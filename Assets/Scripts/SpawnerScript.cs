using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour {

    public Transform poulpi;
    private int delay;
    private float height;
    private bool gameOver;
    private static SpawnerScript spawner;

    void Start () {
        delay = 10;
        height = Screen.height / 2;
        gameOver = false;
        spawner = this;
    }
	
	// Update is called once per frame
	void Update () {
        if (gameOver) {
            return;
        }
        if (delay < 0) {
            Vector3 v3Pos = Camera.main.ViewportToWorldPoint(new Vector3(1.1f, Random.Range(0.2f, 0.8f), 5f)); 
            delay = Random.Range(40, 60);
            for (int i = delay / 20; i > 0; i--) {
                Transform gc = Instantiate(poulpi, v3Pos, Quaternion.identity) as Transform;
            }
        } else {
            delay--;
        }
	}

    public void GameOver() {
        gameOver = true;
    }

    public static SpawnerScript GetSingleton() {
        return spawner;
    }
}
