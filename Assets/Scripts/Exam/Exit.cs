using UnityEditor;
using UnityEngine;

public class Exit : MonoBehaviour
{
    public void QuitGame()
    {
#if UNITY_EDITOR
        //exits in Editor not build
        EditorApplication.isPlaying = false;
#else
        //quits the build not editor
        Application.Quit();
#endif
    }
}
