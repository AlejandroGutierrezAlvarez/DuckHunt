using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class duck3PMovement : MonoBehaviour
{

    [SerializeField] private float speed = 5;
    private void Update()
    {
        transform.position += transform.right * Time.deltaTime * speed;
    }
}

