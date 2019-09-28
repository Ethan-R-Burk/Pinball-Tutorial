using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenes : MonoBehaviour
{
    public void StartPlay()
    {
        SceneManager.LoadScene("StarterScene");
    }

    public void StopPlaying()
    {
        SceneManager.LoadScene("ExitScene");
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene("WelcomeScene");
    }

    public void ExitGame()
    {
               UnityEditor.EditorApplication.isPlaying = false;
    }
}
