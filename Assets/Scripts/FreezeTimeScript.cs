using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Start or quit the game
/// </summary>
public class FreezeTimeScript : MonoBehaviour
{
    private static FreezeTimeScript instance;
    private bool frozen;
    private int freezeTime;
    private GameObject initial;
    void Awake()
    {
        Application.targetFrameRate = 50;
        frozen = false;
        // Disable them
        initial = gameObject;
        instance = this;
        freezeTime = 500;
        HideAll();

    }

    private void Update()
    {
        if (GetFrozen()) {
            instance.freezeTime -= 1;
        } else {
            HideAll();
        }
    }

    public void HideAll()
    {
        initial.SetActive(false);
    }

    public void ShowAll()
    {
        initial.SetActive(true);
    }

    public static void FreezeTime()
    {
        instance.frozen = !instance.frozen;
        if (GetFrozen()) {
            instance.ShowAll();
        } else {
            instance.HideAll();
        }
    }

    public static bool GetFrozen()
    {
        return instance.frozen && instance.freezeTime > 0;
    }

    public static FreezeTimeScript GetSingleton() {
        return instance;
    }

    public static int GetTimeLeft() {
        return instance.freezeTime / Application.targetFrameRate;
    }
}