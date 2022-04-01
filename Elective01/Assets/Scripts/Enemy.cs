using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Character, IDamageable
{
    public float currentHealth;
    public float attackDamage = 20f;

    void Awake(){
        currentHealth = Health;
    }

    #region Damager
    public void Hit(float damageAmount)
    {
        currentHealth -= damageAmount;

        if (currentHealth <= 0)
        {
           Destroy(gameObject);
        }
    }

    public void Damage(float damageAmount){
        Hit(damageAmount);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            IDamageable damageable = collision.GetComponent<IDamageable>();

            if (damageable != null)
            {
                damageable.Damage(attackDamage);
            }
        }
    }
    #endregion


}
