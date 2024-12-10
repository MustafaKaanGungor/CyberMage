using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class missileSpawner : MonoBehaviour
{
    private float shootingTimer;

    [SerializeField] MissileThrower[] throwers;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        shootingTimer += Time.deltaTime;
        if(shootingTimer > 0.5) {
            throwers[UnityEngine.Random.Range(0,4)].ThrowMissile();
            shootingTimer = 0;
        }
    }
}
