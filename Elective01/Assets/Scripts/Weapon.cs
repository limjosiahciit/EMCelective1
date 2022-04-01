using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public string weaponName;
    public float weaponDamage = 20;

    void OnTriggerEnter2D(Collider2D collision)
    {

        if(collision.tag == "Enemy")
        {
            IDamageable damageable = collision.GetComponent<IDamageable>();
            if (damageable != null)
            {
                damageable.Damage(weaponDamage);
            }
        }

    }
}
