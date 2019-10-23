﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemypace : MonoBehaviour
{
    float timer = 0;
    public Vector2 moveDir;
    public float moveSpeed = 3.0f;
    public float paceDuratioon = 3.0f;
    // Start is called before the first frame update
    void Start()
    {
        moveDir.Normalize();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= paceDuratioon)
        {
            moveDir *= -1;
            timer = 0;
        }
        GetComponent<Rigidbody2D>().velocity = moveDir * moveSpeed;
    }
}
