using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public float bodyDamage = 100;

    public Transform firePoint;
    public GameObject bulletPrefab;

    public float bulletForce = 20f;


    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);   
    }

    void OnTriggerEnter2D(Collider2D collision)
    {

        if(collision.tag == "Enemy")
        {
            IDamageable damageable = collision.GetComponent<IDamageable>();
            if (damageable != null)
            {
                damageable.Damage(bodyDamage);
            }
        }
    }


}
