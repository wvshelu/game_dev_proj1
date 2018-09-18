using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour {

    public GameObject poulpi;
    public GameObject redpoulpi;
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
            if (Random.Range(1, 10) < 9) {
                Vector3 v3Pos = Camera.main.ViewportToWorldPoint(new Vector3(1.1f, Random.Range(0.1f, 0.9f), 5f));
                delay = Random.Range(40, 60);
                Instantiate(poulpi.transform, v3Pos, Quaternion.identity);
            } else {
                Vector3 v3Pos = Camera.main.ViewportToWorldPoint(new Vector3(0.95f, Random.Range(0.1f, 0.9f), 5f));
                Instantiate(redpoulpi.transform, v3Pos, Quaternion.identity);
            }

        } else {
            delay--;
        }
	}

    public void GameOver() {
        gameOver = true;
    }

    public bool GetGameOver() {
        return gameOver;
    }

    public static SpawnerScript GetSingleton() {
        return spawner;
    }
}
