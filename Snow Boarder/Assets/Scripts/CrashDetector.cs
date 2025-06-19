using UnityEngine;

public class CrashDetector : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Ground"))
        {
           Debug.Log("Dead!");
            // Assuming there's a GameManager that handles game state
            // GameManager.Instance.OnPlayerCrash();
        }
    }
}
