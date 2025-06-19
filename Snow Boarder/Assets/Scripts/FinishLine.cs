using System;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class FinishLine : MonoBehaviour
{
    [SerializeField] float delayBeforeReload = 1f; // Delay before reloading the scene
    [SerializeField] ParticleSystem finishEffect;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("Finish Line!");
            finishEffect.Play(); // Play finish effect
            Invoke("reloadScene", delayBeforeReload); // Delay to allow player to see the message
        }
    }
    
    void reloadScene()
    {
        SceneManager.LoadScene("Level1");
    }
}
