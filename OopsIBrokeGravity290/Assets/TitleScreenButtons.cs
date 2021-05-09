using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScreenButtons : MonoBehaviour
{
    public string newLevel;
    public string instructions;
    public string credits;
    public string titlescreen;

    public void Play()
    {
        SceneManager.LoadScene(newLevel);
    }

    public void Instructions()
    {
        SceneManager.LoadScene(instructions);
    }

    public void Credits()
    {
        SceneManager.LoadScene(credits);
    }

    public void Title()
    {
        SceneManager.LoadScene(titlescreen);
    }

    public void Exit()
    {
        Application.Quit();
    }

}
