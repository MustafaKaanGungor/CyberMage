using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ghostie : MonoBehaviour
{
    [SerializeField] GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.CompareTag("enemy")) {
            Debug.Log("heyo?");
            gameManager.GameOver();
        }
    }
}
