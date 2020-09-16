﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireRate : MonoBehaviour
{

    [SerializeField]
    private Rigidbody2D bullet;

    [SerializeField]
    private Transform barrel;

    public float speed = 300f;

    public float fireRate = 0.5f;
    private float nextFire = 0f;
    public Joystick joystick;
    

    // Update is called once per frame
    void Update()
    {
        if(joystick.isActiveAndEnabled && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            var spawnedBullet = Instantiate(bullet, barrel.position, barrel.rotation);
            spawnedBullet.AddForce(barrel.right * speed);
        }
    }
}
