using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickToContinue : MonoBehaviour
{
    public string newLevel;

    public void TaskOnClick()
    {
        SceneManager.LoadScene(newLevel);
    }
}
