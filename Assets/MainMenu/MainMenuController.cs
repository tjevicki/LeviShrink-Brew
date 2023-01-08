using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void OnNewGameClick()
    {
        Debug.Log("New game clicked. Loading a dungeon scene isntance.");
        SceneManager.LoadScene("DungeonScene");
    }
}
