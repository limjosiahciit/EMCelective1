using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Character, IDamageable
{
    public float currentHealth;
    public float attackDamage = 20f;
    public float movementSpeed = 1.5f;

    public GameObject player;
    private Rigidbody2D rb;
    private Vector2 movement;
    void Awake(){
        currentHealth = Health;
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        player = GameObject.FindGameObjectWithTag("Player");

        if(player == null)
        {
            return;
        }
        Vector3 direction = player.transform.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        rb.rotation = angle;
        direction.Normalize();
        movement = direction;
    }

    void FixedUpdate(){
        MoveChar(movement);
    }

    void MoveChar(Vector2 direction)
    {
        rb.MovePosition((Vector2)transform.position + (direction * movementSpeed * Time.deltaTime));
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
