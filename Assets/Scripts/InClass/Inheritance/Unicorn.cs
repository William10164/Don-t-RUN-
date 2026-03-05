using UnityEngine;

public class Unicorn : Creature
{
    private string hornColor;

    public string HornColor { get => hornColor; set => hornColor = value; }

    private Unicorn()
    {
    }


    //constrictor that takes in variables in this class and gives variables
    //to the base class
    public Unicorn(string hornColor, string name, bool hasSpots) 
        : base(name, hasSpots)
    {
        this.hornColor = hornColor;
    }
}
