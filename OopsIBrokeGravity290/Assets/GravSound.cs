using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravSound : MonoBehaviour
{
    AudioSource gravSound;
    // Start is called before the first frame update
    void Start()
    {
        gravSound = GetComponent<AudioSource>();
        enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (enabled)
        {
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                gravSound.Play();
                StartCoroutine(DelayGravity());
            }

            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                gravSound.Play();
                StartCoroutine(DelayGravity());
            }

            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                gravSound.Play();
                StartCoroutine(DelayGravity());
            }

            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                gravSound.Play();
                StartCoroutine(DelayGravity());
            }
        }
    }

    private IEnumerator DelayGravity()
    {
        enabled = false;
        yield return new WaitForSeconds(0.5f);
        enabled = true;
    }
}
