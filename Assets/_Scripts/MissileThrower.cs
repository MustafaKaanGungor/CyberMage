using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileThrower : MonoBehaviour
{
    [SerializeField] int horizontalOrVertical; 
    [SerializeField] GameObject cursor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ThrowMissile() {
        Vector3 pos = Vector3.zero;

        switch (horizontalOrVertical)
        {
            case 0:
            pos = new Vector3(15,Random.Range(-4,4),0);
            break;
            case 1:
            pos = new Vector3(-15,Random.Range(-4,4),0);
            break;
            case 2:
            pos = new Vector3(Random.Range(-4,4),10,0);
            break;
            case 3:
            pos = new Vector3(Random.Range(-4,4),-10,0);
            break;
            default:
            break;
        }

        Instantiate(cursor,pos,gameObject.transform.rotation);
    }
}
