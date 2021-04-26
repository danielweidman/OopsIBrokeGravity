using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Repulsion : MonoBehaviour
{
    private AreaEffector2D effector;

    public void SetAngle(int angle) {
        effector = this.GetComponent<AreaEffector2D>();
        effector.forceAngle = angle;
    }
}
