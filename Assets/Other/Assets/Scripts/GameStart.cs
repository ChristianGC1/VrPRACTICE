using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStart : MonoBehaviour
{
    IEnumerator Start()
    {
        //Wait for 20 secs.
        yield return new WaitForSeconds(20);
        //Load scene 1(Game Scene)
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    }
}
