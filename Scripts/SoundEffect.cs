using UnityEngine;

public class SoundEffect : MonoBehaviour
{
    public AudioSource audioSource;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!audioSource.isPlaying)
        {
            audioSource.Play();
        }
    }
}
