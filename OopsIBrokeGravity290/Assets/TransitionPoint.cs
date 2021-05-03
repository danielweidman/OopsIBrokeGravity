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

<<<<<<< HEAD
    private bool count;

=======
>>>>>>> 99d97ef113d393131fb2b971597dc7cd676fde18
    void Start()
    {
        finished = GetComponent<AudioSource>();
    }

<<<<<<< HEAD
    public bool getCount()
=======
    public float getCount()
>>>>>>> 99d97ef113d393131fb2b971597dc7cd676fde18
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