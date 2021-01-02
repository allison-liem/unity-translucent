using UnityEngine;

public class OcclusionDetector : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collider2D)
    {
        if (collider2D.gameObject.CompareTag("Occludable"))
        {
            Debug.Log("Entered an occludable region!");
        }
    }

    void OnTriggerExit2D(Collider2D collider2D)
    {
        if (collider2D.gameObject.CompareTag("Occludable"))
        {
            Debug.Log("Exited an occludable region!");
        }
    }
}
