using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Start or quit the game
/// </summary>
public class GameOverScript : MonoBehaviour
{
    private static GameOverScript instance;
    private GameObject initial;
    void Awake()
    {
        instance = this;
        // Disable them
        initial = gameObject;
        HideAll();
    }

    public void HideAll()
    {
        initial.SetActive(false);
    }

    public void ShowAll()
    {
        initial.SetActive(true);
    }

    public static GameOverScript GetSingleton() {
        return instance;
    }
}