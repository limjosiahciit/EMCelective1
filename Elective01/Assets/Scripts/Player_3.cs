using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_3 : Player
{
    public float movementSpeed = 2.5f;
    public float hitDamage = 35f;

    private void Start()
    {
        moveSpeed = movementSpeed;
        weaponDamage = hitDamage;
    }
}
