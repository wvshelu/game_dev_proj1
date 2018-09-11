using UnityEngine;

/// <summary>
/// Title screen script
/// </summary>
public class MenuScript : MonoBehaviour
{

    public void StartGame()
    {
        // "Stage1" is the name of the first scene we created.
        Application.LoadLevel("Stage1");
    }

    private void Update()
    {

        if (Input.GetKeyDown("space")) {
            Application.LoadLevel("Stage1");
        }
    }
}