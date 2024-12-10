using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] GameObject[] spawnPoints;
    [SerializeField] GameObject enemy;
    private float spawnTimer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        spawnTimer += Time.deltaTime;
        if(spawnTimer > 5) {
            foreach (var item in spawnPoints)
            {
                Instantiate(enemy, item.transform.position, item.transform.rotation);
            }
            spawnTimer = 0;
        }
    }
}
