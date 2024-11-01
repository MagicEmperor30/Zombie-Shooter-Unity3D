using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] float hitPoints = 100f;
    [SerializeField] AudioClip hurtSound; // Reference to the hurt sound audio clip
    [SerializeField] AudioClip deathSound;//reference to the death soudn audio clip
    private AudioSource audioSource; // Reference to the AudioSource

    void Start()
    {
        // Get or add the AudioSource component
        audioSource = gameObject.AddComponent<AudioSource>();
    }

    public void TakeDamage(float damage)
    {
        hitPoints -= damage;

        // Play the hurt sound
        if (!audioSource.isPlaying)
        {
            audioSource.PlayOneShot(hurtSound); // Play the hurt sound clip
        }

        if (hitPoints <= 0)
        {
            audioSource.PlayOneShot(deathSound);
            GetComponent<DeathHandler>().HandleDeath();
        }
    }
}
