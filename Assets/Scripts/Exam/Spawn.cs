using UnityEngine;
using UnityEngine.InputSystem;

public class Spawn : MonoBehaviour
{
    private InputAction spawnAction;
    // new inputaction not old inputaction.


    [SerializeField] private Transform spawnPoints;
    // Assign in Inspector.

    [SerializeField] GameObject boxPrefab;
    // The object that in the list that will be the box the spawner will use
    // to summon the box.

  
    void Start()
    {

        spawnAction = InputSystem.actions.FindAction("Spawner");
        // Assignning what the action is in the inputsystem. new inputaction
        // not old inputaction.

        spawnAction.performed += SpawnAction_performed;

        Debug.Log("Spawn working");
        // A tester to see if the list code is working.

    }

    private void SpawnAction_performed(InputAction.CallbackContext obj)
    {
        GameObject newBox;
        // Making a new value so that the box game be added to the list while
        //spawning in.

        newBox = Instantiate(boxPrefab, spawnPoints.position,
            Quaternion.identity);
        //This code makes the boxes be spawn.

        Debug.Log("Spawner");
        // Unity will break without this.

        Debug.Log("Spawner working");
        // A tester to see if the list code is working.
    }

    
}

