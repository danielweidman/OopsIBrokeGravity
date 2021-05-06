using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Experimental.Rendering;
using UnityEngine.SceneManagement;

public class TransitionPoint : MonoBehaviour
{
    [SerializeField] private string newLevel;
    [SerializeField] GameObject entering;
    [SerializeField] float numberTargets;
    GameObject green;
    [SerializeField] GameObject orange;
    private bool done = false;

    private bool count = false;


    public void Awake()
    {
        green = GameObject.Find("Green Target");
    }

    void Update()
    {

        if(green.gameObject == null)
        {
            green = GameObject.Find("Green Target");
        }
        if (done == true)
        {
            SceneManager.LoadScene(newLevel);
        }
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
                    if (green.gameObject.GetComponent<ColliderPoint>().getCount() == true)
                    {
                        if (orange == null)
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
