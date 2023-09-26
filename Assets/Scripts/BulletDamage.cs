using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDamage : MonoBehaviour
{
    public int Damage = 10;
    private void OnTriggerEnter(Collider other)
    {
        EnemyTank enemyTank = other.GetComponent<EnemyTank>();
        if (enemyTank != null)
        {
            enemyTank.TakeDamage(Damage);
        }

        Destroy(gameObject);
    }
}
