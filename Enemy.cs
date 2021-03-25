using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, IDamagable
{

    public int Health { get; set; }

    public void Damage(int damageAmount)
    {
        Health -= damageAmount;
        Debug.Log("Enemy Health is: " + Health);
    }

    void Start()
    {
        Health = 100;
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Damage(1);
        }
    }
}
