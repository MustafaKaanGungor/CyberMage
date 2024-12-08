using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float speed = 100;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 newPos = mousePos - transform.position;
        newPos = newPos * speed;
        newPos.Normalize(); 
        rb.velocity = newPos;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
