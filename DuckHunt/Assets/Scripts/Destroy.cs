using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    private bool permanet = true;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);    
        
    }

    private void OnMouseDown()
    {
        Debug.Log("click en el pato");

    }

    public void DestroyDuck()
    {
        Destroy(gameObject);
    }


}
