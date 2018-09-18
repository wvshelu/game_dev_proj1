using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeLeftScript : MonoBehaviour {

    public Text m_TimeLeft;
    // Use this for initialization
    void Start () {
        m_TimeLeft.text = FreezeTimeScript.GetTimeLeft() + "";
	}
	
	// Update is called once per frame
	void Update () {
        m_TimeLeft.text = FreezeTimeScript.GetTimeLeft() + "";
    }
}
