using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class trigger : MonoBehaviour
{
    public GameObject endTrigger;
   

    private void OnTriggerEnter(Collider other)
    {

        if (endTrigger != null)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -1);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }

}
