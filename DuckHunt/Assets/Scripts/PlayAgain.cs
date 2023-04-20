using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayAgain : MonoBehaviour
{
    public void Load()
    {
        int playagain = SceneManager.GetActiveScene().buildIndex - 1;

        if (playagain < SceneManager.sceneCountInBuildSettings)
        {
            playagain = 0;
        }
        SceneManager.LoadScene(playagain);
    }
}
