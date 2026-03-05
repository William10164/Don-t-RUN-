using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

public class OnandOff : MonoBehaviour
{

   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        

        //Fading();
        StartCoroutine(Fading());    //Start the fading coroutine
    }

    private IEnumerator Fading()
    {
        Color c = GetComponent<SpriteRenderer>().color;
        while (true)
        {
            for (float aValue = 1.0f; aValue > 0.0f; aValue -= 0.01f)
            {
                c.a = aValue;
                GetComponent<SpriteRenderer>().color = c;

                yield return new WaitForSeconds(0.0f);


            }

            for (float aValue = 0.0f; aValue < 1.0f; aValue += 0.01f)
            {
                c.a = aValue;
                GetComponent<SpriteRenderer>().color = c;

                yield return new WaitForSeconds(0.0f);
            }
        }

        

    }
}
