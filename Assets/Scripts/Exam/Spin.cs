using UnityEngine;

public class Spin : MonoBehaviour
{
   
    /// <summary>
    /// This code make the object rotate at the x axis.
    /// </summary>
    void Update()
    {
        //It rotating the gameObject Z axis.
        transform.Rotate(0, 0, 2);
    }
}
