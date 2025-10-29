using UnityEngine;

public class Trigger_Sound1 : MonoBehaviour
{
    public AudioSource sound1;

    private void OnTriggerEnter(Collider other)
    {
        sound1.Play();
    }
}
