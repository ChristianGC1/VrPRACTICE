using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
    void OnTriggerEnter(Collider collider)
    {
        Debug.Log("Collided!" + collider.gameObject.name);
        if (collider.gameObject.CompareTag("Player"))
        {
            Finish();
        }
    }

    void Finish()
    {
        Debug.Log("Win!");
        UnityEngine.SceneManagement.SceneManager.LoadScene(2);
    }    
}
