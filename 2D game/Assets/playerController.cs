using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    private Vector2 direction;
    public float speed = 5f;
    public Transform target;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        faceMouse();
    }

    private void FixedUpdate()
    {
        movement();
    }

    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    Destroy(gameObject);
    //}

    private void faceMouse()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        direction = mousePosition - transform.position;

        transform.up = direction;
    }

    void movement()
    {
        if (direction.magnitude >= 0.5) {
            rb.velocity = transform.up * speed;
        }
        else
        {
            rb.velocity = transform.up * 0f;
        }
        
    }
}
