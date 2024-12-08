using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class enemy : MonoBehaviour
{
    Rigidbody2D enemyRb;
    private GameObject ghostie;
    [SerializeField] GameManager gameManager;

    void Start()
    {
        enemyRb = gameObject.GetComponent<Rigidbody2D>();

        ghostie = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        Vector2 ghostiePos = ghostie.transform.position;

        gameObject.transform.position = Vector2.MoveTowards(transform.position, ghostiePos,  Time.deltaTime);

    }

    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.CompareTag("ghostie")) {
            Debug.Log("heyo?");
            gameManager.GameOver();
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.CompareTag("bullet")) {
            Destroy(this.gameObject);
        }
    }

}
