using Unity.VisualScripting;
using UnityEngine;

public class Animal 
{
    #region Variables       
    private string name;
    private string type;
    private int age;
    private Color color;
    #endregion

    #region Accessors
    public string Name { get => name; set => name = value; }
    public string Type { get => type; set => type = value; }
    public int Age { get => age; set => age = value; }
    public Color Color { get => color; set => color = value; }
    #endregion

    public Animal()
    {
        name = "King George";
        type = "Penguin";
         age = 7;
        color = Color.blue;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="name"></param>
    /// <param name="type"></param>
    /// <param name="age"></param>
    /// <param name="color"></param>
    public Animal(string name, string type, int age, Color color)
    {
        Name= name;
        Type = type;
        Age = age;  
        Color = color;

        //this.name = name;

    }
 
    /// <summary>
    /// Constructor that takes name and age as parameters
    /// </summary>
    /// <param name="name"></param>
    /// <param name="age"></param>
     public Animal(string name, int age)
    {
        this.name = name;
        this.age = age;

        type = "Giraffe";
        color = Color.green; 
    }

    
    public void OutputDetails()
    {
        Debug.Log(name + " is a " + age + " year old " + color + " " + type);
    }

    /// <summary>
    /// Function that prints out the details of the animal
    /// </summary>
    ~Animal()
    {
        
    }
}
