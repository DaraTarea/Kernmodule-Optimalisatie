using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class GenericTrigger : MonoBehaviour
{
    public PlayableDirector director;
    private bool hasTriggered;

    private void OnTriggerEnter(Collider other)
    {
        
        if(director != null && !hasTriggered)
        {
            director.Play();
            hasTriggered = true;
        }
    }


}

