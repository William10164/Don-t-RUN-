using UnityEngine;


[CreateAssetMenu(fileName = "Weapon", menuName = "ScriptableObjects/Weapon")]

public class Weapon : ScriptableObject
{
   [SerializeField] private string weaponName;
   [SerializeField] private string description;
   [SerializeField] private int damage;

    public string WeaponName { get => weaponName; set => weaponName = value; }
    public string Description { get => description; 
        set => description = value; }
    public int Damage { get => damage; set => damage = value; }

    /// <summary>
    /// Displays info about the weapon
    /// </summary>
    /// <returns></returns>
    public string DisplayWeaponInfo()
    {
        string info = "Name: " + weaponName + "\nDescription: " + description + 
            "\nDamage:" + damage;

        return info;
    }

}
