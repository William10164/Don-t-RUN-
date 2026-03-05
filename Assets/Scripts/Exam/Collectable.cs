using TMPro;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    [SerializeField] private TMP_Text collectableText;
    private int collectableCount;
    



    void Start()
    {
        collectableCount = 0;
        collectableText.text = "Collectable:" + collectableCount.ToString();
    }
    /// <summary>
    /// Increases the coin total and destorys the coin aka it has been 
    /// collected
    /// </summary>
    /// <param name="triggerObject"></param>
    private void OnTriggerEnter2D(Collider2D triggerObject)
    {
        if (triggerObject.gameObject.CompareTag("CollectableTag"))
        {
            collectableCount++;
            collectableText.text = "Collectable:" + 
                collectableCount.ToString();
            Destroy(triggerObject.gameObject);
        }
    }
}
