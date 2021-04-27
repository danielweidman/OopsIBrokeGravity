using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GravityControl : MonoBehaviour
{
    private Rigidbody2D rb2d;
    public GameObject panel;

    public bool enabled;

    public void setEnabled(bool value)
    {
        enabled = value;
    }

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (enabled)
        {
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                Physics2D.gravity = new Vector2(-9.8f, 0);
                rb2d.gravityScale = 1.5f;
                panel.gameObject.SetActive(true);
                StartCoroutine(DelayGravity());
            }

            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                Physics2D.gravity = new Vector2(9.8f, 0);
                rb2d.gravityScale = 1.5f;
                panel.gameObject.SetActive(true);
                StartCoroutine(DelayGravity());
            }

            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                Physics2D.gravity = new Vector2(0, 9.8f);
                rb2d.gravityScale = 1.5f;
                panel.gameObject.SetActive(true);
                StartCoroutine(DelayGravity());
            }

            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                Physics2D.gravity = new Vector2(0, -9.8f);
                rb2d.gravityScale = 1.5f;
                panel.gameObject.SetActive(true);
                StartCoroutine(DelayGravity());
            }
        }
        else if (!enabled)
        {
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                Physics2D.gravity = new Vector2(0.0f, 0);
                rb2d.gravityScale = 0.0f;
                panel.gameObject.SetActive(true);
            }
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                Physics2D.gravity = new Vector2(0.0f, 0);
                rb2d.gravityScale = 0.0f;
                panel.gameObject.SetActive(true);
            }

            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                Physics2D.gravity = new Vector2(0.0f, 0);
                rb2d.gravityScale = 0.0f;
                panel.gameObject.SetActive(true);
            }

            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                Physics2D.gravity = new Vector2(0.0f, 0);
                rb2d.gravityScale = 0.0f;
                panel.gameObject.SetActive(true);
            }

        }

    }

    private IEnumerator DelayGravity()
    {
        enabled = false;
        yield return new WaitForSeconds(0.5f);
        panel.gameObject.SetActive(false);
        enabled = true;
    }
}