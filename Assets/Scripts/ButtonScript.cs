using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour {

	private int counter;
	private GameObject image;
	private bool active;
	// Use for initialization
	void Start () {
		counter = 0;
        image = transform.GetChild(0).gameObject;
		active = true;
	}

    public void StartGame()
    {
        // "Stage1" is the name of the first scene we created.
        Application.LoadLevel("Stage1");
    }

	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("space")) {
			StartGame();
        }
		if (counter < 20) {
			counter++;
		} else {
			active = !active;
            image.SetActive(active);
			counter = 0;
		}
	}


}
