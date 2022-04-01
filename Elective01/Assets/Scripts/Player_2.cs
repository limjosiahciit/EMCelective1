using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_2 : Player
{
    public float movementSpeed = 5f;
    public float hitDamage = 15f;

    private void Start()
    {
        moveSpeed = movementSpeed;
        weaponDamage = hitDamage;
    }
}