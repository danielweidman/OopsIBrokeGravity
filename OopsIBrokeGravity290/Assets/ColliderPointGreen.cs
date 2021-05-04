using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderPointGreen : MonoBehaviour
{
    GameObject entering;
    private bool count = false;


    void Start()
    {
        entering = GameObject.Find("Green Block");
    }

    public void setCount(bool x)
    {
        count = x;
    }

    public bool getCount()
    {
        return count;
    }


    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject == entering)
        {
            setCount(true);
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