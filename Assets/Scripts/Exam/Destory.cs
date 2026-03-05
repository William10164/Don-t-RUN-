using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Destory : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        StartCoroutine(destory());

    }


    private IEnumerator destory()
    {
        yield return new WaitForSeconds(5.0f);

        Debug.Log("Destory on");

        Destroy(this.gameObject);

      
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
