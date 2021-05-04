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
    [SerializeField] GameObject green;
    [SerializeField] GameObject orange;
    private bool done = false;

    private bool count = false;


    void Update()
    {
        if (done == true)
        {
            SceneManager.LoadScene(newLevel);
        }
    }

    void Start()
    {
 
    }

    public bool getCount()
    {
        return this.count;
    }

    public void setCount(bool x)
    {
        this.count = x;
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject == entering)
        {
            setCount(true);
            if (this.count){
                if( green.gameObject.GetComponent<ColliderPoint>().getCount() == true){
                   if(orange.gameObject == null)
                    {
                        
                        done = true;
                    }
                if (orange.gameObject != null && orange.gameObject.GetComponent<ColliderPoint>().getCount() == true)
                    {
                        done = true;
                    }    
                 }
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
