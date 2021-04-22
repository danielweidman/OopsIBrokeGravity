using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderPoint : MonoBehaviour
{
    [SerializeField] GameObject entering;
    [SerializeField] float numberTargets;
    [SerializeField] GameObject transitionPoint;


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == entering)
        {
            transitionPoint.GetComponent<TransitionPoint>().setCount(transitionPoint.GetComponent<TransitionPoint>().getCount() + 1);
        }

    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject == entering)
        {
            transitionPoint.GetComponent<TransitionPoint>().setCount(transitionPoint.GetComponent<TransitionPoint>().getCount() - 1);
        }
    }
}