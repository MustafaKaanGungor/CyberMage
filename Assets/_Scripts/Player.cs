using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
   
    private Rigidbody2D playerRB;

    private void Awake() 
    {
        playerRB = gameObject.GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        
    }

    private void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        Vector2 movement = new Vector2(x,y);

        playerRB.AddForce(movement * 500 * Time.deltaTime);
    }

    private void FixedUpdate() 
    {
        
    }
}
