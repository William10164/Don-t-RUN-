using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collidingObject)
    {
        if (collidingObject.gameObject.name == "Player")
        {

            ///Load the next scene in the Build Profiles-> level
            SceneManager.LoadScene(SceneManager.GetActiveScene()
                .buildIndex + 1);

        }
    }
}
