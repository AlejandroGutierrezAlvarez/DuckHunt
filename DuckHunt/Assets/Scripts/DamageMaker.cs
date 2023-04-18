using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageMaker : MonoBehaviour
{
    public int Damage;
    public bool Permanent = true;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        Health health = collision.GetComponent<Health>();
        if (health != null)
        {
            health.TakeDamage(Damage);
            if (!Permanent)
            {
                Destroy(gameObject);
            }
        }

    }
}