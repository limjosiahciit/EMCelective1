using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_1 : Player
{
    public float movementSpeed = 7f;
    public float hitDamage = 25f;

    private void Start()
    {
        moveSpeed = movementSpeed;
        weaponDamage = hitDamage;
    }
}
