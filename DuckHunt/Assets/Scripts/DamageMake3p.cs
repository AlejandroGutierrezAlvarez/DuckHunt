using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageMake3p : MonoBehaviour
{
    private int currentHealth;
    public int MaxHealth = 3;

    private void Start()
    {
        currentHealth = MaxHealth;
    }

    private void OnMouseDown()
    {
        if (MaxHealth != 0)
        {
            currentHealth--;
            
            if (currentHealth == 0)
            {
                PointCounter.Instance.GetPoints3p();
                Destroy(gameObject);
            }
        }

    }
}
