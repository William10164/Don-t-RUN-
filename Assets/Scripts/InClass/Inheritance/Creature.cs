using UnityEngine;

public class Creature 
{
    private string name;
    private bool hasSpots;

    
    public bool HasSpots { get => hasSpots; set => hasSpots = value; }
    public string Name { get => name; set => name = value; }

    //default required constructor

    public Creature()
    {

    }

    public Creature(string name, bool hasSpots)
    {
        this.name= name;
        this.hasSpots= hasSpots;
    }

    public virtual void DisplayCreatureInfo()
    {
        if (this.hasSpots)
        {
            Debug.Log(name + " has spots");
        }

        else
        {
            Debug.Log(name + " is spotless! ");
        }

        //Using the Conditional Operator
        Debug.Log(hasSpots ? name + " has spots!" : name + " is spotless");
        
    }
}
