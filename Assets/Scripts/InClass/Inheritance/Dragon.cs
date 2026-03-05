using UnityEngine;

public class Dragon : Creature
{
    private string wingColor;


    public string WingColor { get => wingColor; set => wingColor = value; }

    //default empty constructor
    public Dragon()
    {
    }

    //constructor that passes values to the base Creature
    public Dragon(string name, bool hasSpots) : base(name,hasSpots) 
    {

    }

    public override void DisplayCreatureInfo()
    {
        base.DisplayCreatureInfo();
        Debug.Log("And has " + wingColor + "wings!");


    }
}
