using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour
{
    [SerializeField] private List<Weapon> weapons = new List<Weapon>();


    void Start()
    {
        foreach (var weapon in weapons)
        {
            Debug.Log(weapon.DisplayWeaponInfo());
        }

    }
}


