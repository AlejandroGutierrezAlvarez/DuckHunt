using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Health : MonoBehaviour
{
    private int currentHealth;
    public int MaxHealth;

    private void Start()
    {
        currentHealth = MaxHealth;  
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        if (currentHealth <= 0)
        {
            Destroy(gameObject);     
        }
    }
}