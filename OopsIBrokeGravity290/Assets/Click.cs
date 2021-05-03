using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour
{
    [SerializeField] private GameObject repulsiveObjectPrefab;
    [SerializeField] private GameObject panel;
    private GameObject repulsiveObject;
    private int repulsiveAngle;
    private Vector3 rotation;
    private Repulsion repulsionScript;

    private RectTransform rectTransform;
    private int currentZ = 0;

    // Start is called before the first frame update
    void Start()
    {
        repulsiveAngle = 0;
        rotation = new Vector3(0, 0, 0);

        rectTransform = panel.GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            Vector3 mousePos = Input.mousePosition;
            Vector3 position = Camera.main.ScreenToWorldPoint(mousePos);
            Debug.Log(mousePos);
            Debug.Log(position);
            SpawnRepulsiveObject(position);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
        {
            //arrow.transform.localRotation = Quaternion.Euler(new Vector3(0, 0, 90));
            //rectTransform.Rotate(new Vector3(0, 0, 90));

            if (currentZ == 0)
            {
                rectTransform.Rotate(new Vector3(0, 0, 90));
            }
            if (currentZ == 180)
            {
                rectTransform.Rotate(new Vector3(0, 0, 270));
            }
            if (currentZ == 270)
            {
                rectTransform.Rotate(new Vector3(0, 0, 180));
            }
            currentZ = 90;
            repulsiveAngle = 180;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
        {
            //arrow.transform.localRotation = Quaternion.Euler(new Vector3(0, 0, 270));
            //rectTransform.Rotate(new Vector3(0, 0, 270));

            if (currentZ == 90)
            {
                rectTransform.Rotate(new Vector3(0, 0, 180));
            }
            if (currentZ == 180)
            {
                rectTransform.Rotate(new Vector3(0, 0, 90));
            }
            if (currentZ == 0)
            {
                rectTransform.Rotate(new Vector3(0, 0, 270));
            }
            currentZ = 270;
            repulsiveAngle = 0;
        }

        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
        {
            //arrow.transform.localRotation = Quaternion.Euler(new Vector3(0, 0, 0));
            if (currentZ == 90) 
            {
                rectTransform.Rotate(new Vector3(0, 0, 270));
            }
            if(currentZ == 180)
            {
                rectTransform.Rotate(new Vector3(0, 0,  180));
            }
            if (currentZ == 270)
            {
                rectTransform.Rotate(new Vector3(0, 0, 90));
            }
            currentZ = 0;
            repulsiveAngle = 90;
        }

        if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))
        {
            //arrow.transform.localRotation = Quaternion.Euler(new Vector3(0, 0, 180));
            //rectTransform.Rotate(new Vector3(0, 0, 180));

            if (currentZ == 90)
            {
                rectTransform.Rotate(new Vector3(0, 0, 90));
            }
            if (currentZ == 0)
            {
                rectTransform.Rotate(new Vector3(0, 0, 180));
            }
            if (currentZ == 270)
            {
                rectTransform.Rotate(new Vector3(0, 0, 270));
            }
            currentZ = 180;
            repulsiveAngle = 270;
        }
    }

    void SpawnRepulsiveObject(Vector3 position)
    {

        if (repulsiveObject != null)
        {
            Destroy(repulsiveObject);
        }
        repulsiveObject = Instantiate(repulsiveObjectPrefab) as GameObject;
        repulsionScript = repulsiveObject.GetComponent<Repulsion>();
        repulsionScript.SetAngle(repulsiveAngle);

        if (repulsiveAngle == 90)
        {
            repulsiveObject.transform.localRotation = Quaternion.Euler(new Vector3(0, 0, 0));
        }
        if(repulsiveAngle == 180)
        {
            repulsiveObject.transform.localRotation = Quaternion.Euler(new Vector3(0, 0, 90));
        }
        if (repulsiveAngle == 270) 
        {
            repulsiveObject.transform.localRotation = Quaternion.Euler(new Vector3(0, 0, 180));
        }
        if (repulsiveAngle == 0)
        {
            repulsiveObject.transform.localRotation = Quaternion.Euler(new Vector3(0, 0, 270));
        }

        repulsiveObject.transform.position = new Vector3(position.x, position.y, -0.2f);
    }
}
