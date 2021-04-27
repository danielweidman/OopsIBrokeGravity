using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using DG.Tweening;

public class ToggleSwitch : MonoBehaviour, IPointerDownHandler
{
    [SerializeField] private bool _isOn = false;
    public bool isOn
    {
        get
        {
            return _isOn;
        }
    }

    public GameObject blue;
    public GameObject green;


    [SerializeField] private RectTransform toggleIndicator;
    [SerializeField] private Image backgroundImage;
    private Color onColor = Color.green;
    private Color offColor = Color.red;
    private float offX;
    private float onX;
    [SerializeField] private float tweenTime = 0.25f;


    public delegate void ValueChanged(bool value);
    public event ValueChanged valueChanged;
    // Start is called before the first frame update
    void Start()
    {
        offX = toggleIndicator.anchoredPosition.x;
        onX = (backgroundImage.rectTransform.rect.width - toggleIndicator.rect.width)*0.5f;

    }

    private void OnEnable()
    {
        Toggle(isOn);
    }


    public void Toggle(bool value)
    {
        if(value != isOn)
        {
            _isOn = value;
            /* if (GameObject.Find("Orange Block") != null)
             {
                 GameObject orange = GameObject.Find("Orange Block");
                 orange.GetComponent<GravityControl>().setEnabled(false);
             } **/
            if (value == true)
            {
                blue.GetComponent<GravityControl>().setEnabled(true);
                green.GetComponent<GravityControl>().setEnabled(true);
            }
            else if (value == false)
            {
                blue.GetComponent<GravityControl>().setEnabled(false);
                green.GetComponent<GravityControl>().setEnabled(false);
            }


            ToggleColor(isOn);
            MoveIndicator(isOn);
            if(valueChanged != null)
            {
                valueChanged(isOn);
            }
        }
        else
        {
      
            /*if (GameObject.Find("Orange Block") != null)
            {
                GameObject orange = GameObject.Find("Orange Block");
                orange.GetComponent<GravityControl>().setEnabled(true);
            } **/


        }
    }

    private void ToggleColor(bool value)
    {
        if (value)
            backgroundImage.DOColor(onColor, tweenTime);
        else
            backgroundImage.DOColor(offColor, tweenTime);
    }

    private void MoveIndicator(bool value)
    {
        if (value)
            toggleIndicator.DOAnchorPosX(onX, tweenTime);
        else
            toggleIndicator.DOAnchorPosX(offX, tweenTime);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Toggle(!isOn);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
