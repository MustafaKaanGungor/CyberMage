using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tower : MonoBehaviour
{
    private Vector3 firepoint;

    private void Awake() {
        firepoint = transform.Find("FirePoint").position;
    }
}
