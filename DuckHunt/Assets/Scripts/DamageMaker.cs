using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageMaker : MonoBehaviour
{

    private int currentHealth;
    public int MaxHealth = 1;


    private void Awake()
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
                PointCounter.Instance.GetPoints1p();
                Destroy(gameObject);             
            }
        }
    }
}