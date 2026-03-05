using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    private InputAction moveAction; 
    //I need this for player movement speed code
    private Vector2 moveData;        
    //I need this for player movement speed code
    public float speed;            
    //I need this for player movement speed code
    private Rigidbody2D myRb;
    
    void Start()
    {
        // Need rigidbody2D in order for the player controller script to work.
        myRb = GetComponent<Rigidbody2D>();

        moveAction = InputSystem.actions.FindAction("Move");     
        //I need this for player movement speed code
    }

    // Update is called once per frame
    void Update()
    {
        moveData = moveAction.ReadValue<Vector2>(); 
        //I need this for player movement speed code
                                                   
        //reads in the x/y input and saves it in moveData
    }

    private void FixedUpdate()
    {
        myRb.linearVelocity = new Vector2(moveData.x * speed, 0);

        // This is the code for adding the speed for player movement in x,y.
    }

}
