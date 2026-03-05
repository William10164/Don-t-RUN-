using System.Collections.Generic;
using UnityEngine;

public class Zoo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the
    // MonoBehaviour is created
    void Start()
    {
        Animal a1 = new Animal();
        Debug.Log(a1.Name);

        Animal a2 = new Animal("Stewart", "Jaguar", 80, Color.red);
        Debug.Log(a2.Name + " is a " + a2.Color.ToString() + " " + a2.Type);

        Animal a3 = new Animal("Maurice", 42);
        Debug.Log(a3.Name + " is a " + a3.Type);

        Animal a4 = new Animal("Kevinette", 3);
        Debug.Log(a4.Name + " is a " + a4.Type);

        a1.OutputDetails();
        a2.OutputDetails();
        a3.OutputDetails();
        a4.OutputDetails();

        //More effiecient way of the above code
        List<Animal> zooAnimals = new List<Animal>() { a1, a2, a3, a4 };

        for (int i = 0; i < zooAnimals.Count; i++)
        {
            zooAnimals[i].OutputDetails();
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
