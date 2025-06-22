using UnityEngine;

public class DustTrail : MonoBehaviour
{
    [SerializeField] ParticleSystem dustParticles; // Reference to the ParticleSystem for dust

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the collision is with the ground layer
        if (collision.gameObject.CompareTag("Ground"))
        {
            // Play the dust particles when colliding with the ground
            dustParticles.Play();
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        // Check if the collision is with the ground layer
        if (collision.gameObject.CompareTag("Ground"))
        {
            dustParticles.Stop(); // Stop the dust particles when no longer colliding with the ground
        }
    }
}
