using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class TimelineStarter : MonoBehaviour
{
    public GameObject cutCamera;

    private void OnTriggerEnter(Collider other)
    {
        PlayableDirector pd = cutCamera.GetComponent<PlayableDirector>();
        if (pd != null)
        {
            pd.Play();
        }
    }
}
