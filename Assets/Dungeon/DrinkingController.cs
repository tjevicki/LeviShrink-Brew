using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrinkingController : MonoBehaviour
{
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
                Debug.Log("Drank a " + drunkPotion.PotionName() + ".");
            }
        }
    }
}
