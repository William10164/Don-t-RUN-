using UnityEngine;
using UnityEngine.InputSystem;

public class Growth : MonoBehaviour
{

    private InputAction growthAction;

    private InputAction mousepoitionAction;

    
    


    
    void Start()
    {

        growthAction = InputSystem.actions.FindAction("Grow");
        // Assignning what the action is in the inputsystem. new inputaction
        // not old inputaction.

        mousepoitionAction = InputSystem.actions.FindAction("MousePosition");

        Debug.Log("Grow list working");
        // A tester to see if the list code is working.
    }

    private void OnMouseDown()
    {
        gameObject.transform.
                      localScale += new Vector3(0.2f, .2f, .2f);


        Debug.Log(" Growing working");
        // A tester to see if the list code is working.
    }

   
}
