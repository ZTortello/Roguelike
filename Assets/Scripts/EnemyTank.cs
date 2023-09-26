using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTank : MonoBehaviour
{
    public int MaxHealth = 100;
    public int CurrentHealt;

    private void Start()
    {
        CurrentHealt = MaxHealth;
    }

    public void TakeDamage(int damage)
    {
        CurrentHealt -= damage;

        if (CurrentHealt <= 0)
        {
            Destroy(gameObject);
        }
    }
}
