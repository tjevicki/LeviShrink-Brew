using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngredientCollisionHandler : MonoBehaviour
{
    private List<string> addedIngredients = new List<string>();

    // Possible ingredients:
    // Gold
    // Wax
    // GoatStomachAcid
    // HemorroidExtract
    // DogVomit

    void OnCollisionEnter(Collision collision)
    {
        PotionIngredient collidingIngredient = collision.gameObject.GetComponent<PotionIngredient>();
        if (collidingIngredient != null)
        {
            Debug.Log("Added a " + collidingIngredient.ingredientId + " into the cauldron.");
            addedIngredients.Add(collidingIngredient.ingredientId);

            Destroy(collision.gameObject);
        }

        GlassController collidingDrinkingController = collision.gameObject.GetComponent<GlassController>();
        if (collidingDrinkingController != null)
        {
            collidingDrinkingController.FillWithPotion(new Potion(addedIngredients));
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
