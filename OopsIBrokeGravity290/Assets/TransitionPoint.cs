using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering;
using UnityEngine.SceneManagement;

public class TransitionPoint : MonoBehaviour
{
    AudioSource finished;
    [SerializeField] private string newLevel;
    [SerializeField] GameObject entering;
    [SerializeField] float numberTargets;
    private float count;

    void Start()
    {
        finished = GetComponent<AudioSource>();
    }

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
                finished.Play();
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