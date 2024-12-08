using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
   
    Rigidbody2D playerRB;

    [SerializeField] GameManager gameManager;
    [SerializeField] GameObject bullet;
    float cooldown;

    [SerializeField] Slider tpSlider;
    [SerializeField] GameObject text;

    private void Awake() 
    {
        playerRB = gameObject.GetComponent<Rigidbody2D>();
        Time.timeScale = 1;
    }

    private void Start()
    {
        
    }

    private void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        Vector2 movement = new Vector2(x,y);
        movement.Normalize();

        playerRB.AddForce(movement * 10);

        /*if(Input.GetKeyDown(KeyCode.Space)) {
            Instantiate(bullet, transform.position, transform.rotation);
        }*/
        cooldown += Time.deltaTime;
        
        if(cooldown < 5) {
            tpSlider.value = cooldown;
            text.SetActive(false);
        } else {
            text.SetActive(true);
        }
        if(Input.GetKeyDown(KeyCode.Space) && cooldown > 5) {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePos = new Vector3(mousePos.x, mousePos.y, 0);
            gameObject.transform.position = mousePos;
            cooldown = 0;
        }
    }

    private void FixedUpdate() 
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.CompareTag("enemyBullet") || other.gameObject.CompareTag("enemy")) {
            gameManager.GameOver();
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.CompareTag("enemyBullet") || other.gameObject.CompareTag("enemy")) {
            gameManager.GameOver();
        }
    }
}
