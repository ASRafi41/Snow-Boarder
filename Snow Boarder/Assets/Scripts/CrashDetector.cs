using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float delayBeforeReload = 0.5f; // Delay before reloading the scene
    [SerializeField] ParticleSystem crashEffect;
    [SerializeField] AudioClip crashSound; // Optional: sound effect for crash
    bool hasCrash = false;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Ground") && !hasCrash)
        {
            Debug.Log("Dead!");
            hasCrash = true;
            FindAnyObjectByType<PlayerController>().DisableMovement(); // Disable player movement
            crashEffect.Play(); // Play crash effect
            GetComponent<AudioSource>().PlayOneShot(crashSound); // Play crash sound
            Invoke("reloadScene", delayBeforeReload); // Delay to allow player to see the message
        }
    }

    void reloadScene()
    {
        SceneManager.LoadScene("Level1");
    }
}
