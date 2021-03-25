using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour, IDamagable
{

    public int Health { get; set; }

    public void Damage(int damageAmount)
    {
        Health -= damageAmount;
        Debug.Log("Player Health is: " + Health);
    }



    
    void Start()
    {
        Health = 100;
    }

    
    void Update()
    {
         if (Input.GetKeyDown(KeyCode.A))
        {
            Damage(1);
        }       
    }
}
