using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class BasicStats
{
    [SerializeField] private float _movementSpeed;
    [SerializeField] private float _health;

    public float MovementSpeed { get => _movementSpeed; set => _movementSpeed = value; }
    public float Health { get => _health; set => _health = value; }
}
