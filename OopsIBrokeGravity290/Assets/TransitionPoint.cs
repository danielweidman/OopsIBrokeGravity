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
    [SerializeField] GameObject green;
    [SerializeField] GameObject orange;

    private bool count;

    void Start()
    {
        finished = GetComponent<AudioSource>();
    }

    public bool getCount()
    {
        return this.count;
    }

    public void setCount(bool x)
    {
        this.count = x;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == entering)
        {
            setCount(true);
            if (this.count && green.gameObject.GetComponent<ColliderPoint>().getCount() == true)
           
                
                if(orange.gameObject == null)
                {
                    finished.Play();
                    SceneManager.LoadScene(newLevel);
                }
            if (orange.gameObject != null && orange.gameObject.GetComponent<ColliderPoint>().getCount() == true)
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
            setCount(false);
        }
    }
}