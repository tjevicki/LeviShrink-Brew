using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class DrinkingController : MonoBehaviour
{
    public GameObject EndGameUI;
    public GameObject EndGameUITitle;
    public GameObject EndGameUIDescription;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        GlassController collidingDrinkingController = other.gameObject.GetComponent<GlassController>();
        if (collidingDrinkingController != null)
        {
            Potion drunkPotion = collidingDrinkingController.potion;

            collidingDrinkingController.Empty();

            if (drunkPotion != null)
            {
                Debug.Log("Drank a " + drunkPotion.PotionInfo().PotionTitle + ".");

                SetEndGameUIText(drunkPotion.PotionInfo());

                Invoke("ShowEndGameUI", 2.0f);
                Invoke("LoadMainMenu", 12.0f);
            }
        }
    }

    private void SetEndGameUIText(PotionInfo PotionInfo)
    {
        EndGameUITitle.GetComponent<TextMeshProUGUI>().text = "You drank a " + PotionInfo.PotionTitle + ".";
        EndGameUIDescription.GetComponent<TextMeshProUGUI>().text = PotionInfo.PotionEffect;
    }

    private void ShowEndGameUI()
    {
        EndGameUI.GetComponent<EndGameUIController>().ShowEndGameUI();
    }

    private void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenuScene");
    }
}
