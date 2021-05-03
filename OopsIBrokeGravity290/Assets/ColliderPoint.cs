using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderPoint : MonoBehaviour
{
    [SerializeField] GameObject entering;
    [SerializeField] float numberTargets;
    [SerializeField] GameObject transitionPoint;
    private bool count = false;
    
    public void setCount(bool x)
    {
        count = x;
    }

    public bool getCount()
    {
        return count;
    }


    void OnTriggerEnter2D(Collider2D other)
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