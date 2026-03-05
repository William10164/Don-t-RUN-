
using System.Collections.Generic;
using UnityEngine;

public class CreatureController : MonoBehaviour
{
   
    private List<Creature> creatures = new List<Creature>();
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        creatures.Add(new Unicorn("purple", "Jellybean", true));
        creatures.Add(new Dragon("Sparkles", false));
        creatures.Add(new Dragon("Goliath", true));
        creatures.Add(new Puppy("Moose", false));
        creatures.Add(new Creature("Bubbles", true));

       //Casting the creature specifically to one type to access its
       //individual variables
        ((Dragon)creatures[1]).WingColor = "Magenta";

        ShowInfo();
    }

    private void ShowInfo()
    {
        creatures[1].DisplayCreatureInfo();

        foreach (Creature c in creatures)
        {
            c.DisplayCreatureInfo();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
