﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("Player entered checkpoint");
            PlayerController player = collision.GetComponent<PlayerController>();
            player.SetCurrentCheckpoint(this);
        }
    }
}
