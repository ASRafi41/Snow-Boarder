using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float delayBeforeReload = 0.5f; // Delay before reloading the scene
    [SerializeField] ParticleSystem crashEffect;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Ground"))
        {
            Debug.Log("Dead!");
            crashEffect.Play(); // Play crash effect
            Invoke("reloadScene", delayBeforeReload); // Delay to allow player to see the message
            // Assuming there's a GameManager that handles game state
            // GameManager.Instance.OnPlayerCrash();
        }
    }
    void reloadScene()
    {
        SceneManager.LoadScene("Level1");
    }
}
