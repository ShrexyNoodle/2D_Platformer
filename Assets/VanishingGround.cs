﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VanishingGround : MonoBehaviour
{

   

    private void OnTriggerEnter2D(Collider2D collision)
    {



        if (collision.tag == "Player")
        {
            Object.Destroy(gameObject, 1f);
        }
    }
}
