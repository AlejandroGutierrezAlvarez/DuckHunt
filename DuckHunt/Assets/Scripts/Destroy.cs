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


}
