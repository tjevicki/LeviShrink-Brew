using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Potion
{
    private List<string> Ingredients;

    private List<string> LeviShrink = new List<string> { 
        "HemorroidExtract",
        "GoatStomachAcid",
        "CarrotSmall",
        "DogVomit",
        "Wax_300",
        "Potato",
        "Ginger"
    };

    private List<string> ShrinkLevi = new List<string> {
        "GoatStomachAcid",
        "HemorroidExtract",
        "DogVomit",
        "CarrotSmall",
        "Potato",
        "Wax_300",
        "Ginger"
    };

    private List<string> Levi = new List<string>
    {
        "HemorroidExtract",
        "CarrotSmall",
        "Wax_300",
        "Ginger"
    };

    private List<string> Shrink = new List<string>
    {
        "GoatStomachAcid",
        "DogVomit",
        "Potato"
    };

    public Potion(List<string> Ingredients)
    {
        this.Ingredients = Ingredients;
    }

    public PotionInfo PotionInfo()
    {
        if (IsMatching(LeviShrink))
        {
            return new PotionInfo("Potion of Levitation and Shrinking", "You shrink to a size of a bean and start levitating. You manage to fly over to the door keyhole and squeeze through. You are saved!", false);
        }

        if (IsMatching(ShrinkLevi))
        {
            return new PotionInfo("Potion of Shrinking and Levitation", "You shrink to a size of a bean and start levitating.You manage to fly over to the door keyhole and squeeze through.You are saved!", false);
        }

        if (IsMatching(Shrink))
        {
            return new PotionInfo("Potion of Shrinking", "You shrink to a size of bean, and now you can't reach anything. You die from thirst, locked away in your dungeon.", true);
        }

        if (IsMatching(Levi))
        {
            return new PotionInfo("Potion of Levitation", "You start levitating and you get stuck on the ceiling, unable to do anything. You die from thirst, locked away in your dungeon.", true);
        }

        return new PotionInfo("Poison of Exploding Eyeballs", "Your eyes start to strain and soon explode, splattering blood and pieces of your brain all over the room.", true);
    }

    private bool IsMatching(List<string> Ingredients)
    {
        if (this.Ingredients.Count == Ingredients.Count)
        {
            bool AreIngredientsMatching = true;

            for (int i = 0; i < this.Ingredients.Count; i++)
            {
                if (this.Ingredients[i] != Ingredients[i])
                {
                    AreIngredientsMatching = false;
                    break;
                }
            }

            return AreIngredientsMatching;
        }

        return false;
    }
}

public struct PotionInfo
{
    public string PotionTitle;
    public string PotionEffect;
    public bool IsDeadly;

    public PotionInfo(string PotionTitle, string PotionEffect, bool IsDeadly)
    {
        this.PotionTitle = PotionTitle;
        this.PotionEffect = PotionEffect;
        this.IsDeadly = IsDeadly;
    }
}
