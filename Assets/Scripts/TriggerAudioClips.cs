using UnityEngine;

public class TriggerAudioClips : MonoBehaviour
{
    public AudioSource sound1;
    public AudioSource sound2;

    private void Start()
    {
        sound1.Pause();
        sound2.Pause();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SOUND EFFECT"))
        {
            sound1.UnPause();
        }

        if (other.CompareTag("SOUND EFFECT2"))
        {
            sound2.UnPause();
        }
    }
}
