using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Health : MonoBehaviour
{
    private int currentHealth;
    public int MaxHealth;

    public TextMeshProUGUI healthText;

    private void Start()
    {
        currentHealth = MaxHealth;
        healthText.text = currentHealth.ToString();
       
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        if (currentHealth <= 0)
        {
            currentHealth = MaxHealth;
           
        }
        healthText.text = currentHealth.ToString();
    }
}