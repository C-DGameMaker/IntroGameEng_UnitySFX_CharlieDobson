using System.Runtime.CompilerServices;
using UnityEngine;

public class Triggers : MonoBehaviour
{
    public AudioSource musicLoop;
    
    private void OnTriggerEnter(Collider other)
    {
        
        
            musicLoop.Pause();
        
        
    }

    private void OnTriggerExit(Collider other)
    {
        
        
            musicLoop.UnPause();
        
        
        
    }
}
