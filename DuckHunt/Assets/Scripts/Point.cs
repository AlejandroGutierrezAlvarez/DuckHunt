using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour
{
    public int value;
    private MeshRenderer rend;
    private Collider myCollider;

    private void Start()
    {
        rend = GetComponentInChildren<MeshRenderer>();
        myCollider = GetComponentInChildren<Collider>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        PointCounter counter = other.GetComponent<PointCounter>();

        if (counter != null)
        {
            counter.GetPoints(value);        
        }
    }
}
