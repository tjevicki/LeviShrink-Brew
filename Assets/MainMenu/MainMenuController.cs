using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{

    public GameObject Menu;
    public GameObject MainScreen;
    public GameObject TutorialScreen;

    public bool IsSummoned = false;

    void Start()
    {
        if (IsSummoned)
        {
            Menu.SetActive(false);
        }
        else
        {
            Menu.SetActive(true);
        }

        MainScreen.SetActive(true);
        TutorialScreen.SetActive(false);
    }

    public void OnNewGameClick()
    {
        Debug.Log("New game clicked. Loading a dungeon scene isntance.");
        SceneManager.LoadScene("DungeonScene");
    }

    public void OnTutorialClick()
    {
        MainScreen.SetActive(false);
        TutorialScreen.SetActive(true);
    }

    public void OnBackClick()
    {
        MainScreen.SetActive(true);
        TutorialScreen.SetActive(false);
    }
}
