using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering;
using UnityEngine.SceneManagement;

public class TransitionPoint : MonoBehaviour
{
    [SerializeField] private string newLevel;
    [SerializeField] GameObject entering;
    [SerializeField] float numberTargets;
    private float count;

    public float getCount()
    {
        return this.count;
    }

    public void setCount(float x)
    {
        this.count = x;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == entering)
        {
            count += 1;
            if (count == numberTargets)
            {
                SceneManager.LoadScene(newLevel);
            }
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject == entering)
        {
            count--;
        }
    }
}