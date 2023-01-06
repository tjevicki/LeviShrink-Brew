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
        Debug.Log("Drank a potion.");

        GlassController collidingDrinkingController = other.gameObject.GetComponent<GlassController>();
        if (collidingDrinkingController != null)
        {
            collidingDrinkingController.Empty(/*makePotionFromIngredients(addedIngredients)*/);
        }
    }
}
