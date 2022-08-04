using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameRestart : MonoBehaviour
{
    IEnumerator Start()
    {
        //Wait for 10 secs.
        yield return new WaitForSeconds(10);
        //Load scene 1(Game Scene)
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    }
}
