using UnityEngine;

public class Puppy : Creature
{
    public Puppy()
    {
    }

    public Puppy(string name, bool hasSpots) : base(name, hasSpots)
    {

    }

    public override void DisplayCreatureInfo()
    {
        Debug.Log("Puppy loves playing with his ball!");
    }
}
