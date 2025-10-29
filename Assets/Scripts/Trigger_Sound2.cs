using UnityEngine;

public class Trigger_Sound2 : MonoBehaviour
{
    public AudioSource sound2;

    private void OnTriggerEnter(Collider other)
    {
        sound2.Play();
    }
}
