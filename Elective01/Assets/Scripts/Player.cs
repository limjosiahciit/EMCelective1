using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character, IDamageable
{
    public float currentHealth;
    public float weaponDamage = 20f;

    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    Vector2 movement;

    void Awake(){
        currentHealth = Health;
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    public void Hit(float damageAmount)
    {
        currentHealth -= damageAmount;

        if (currentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void Damage(float damageAmount)
    {
        Hit(damageAmount);
    }

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        float angle = Mathf.Atan2(movement.y, movement.x) * Mathf.Rad2Deg;
        rb.rotation = angle;
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);

    }
}
