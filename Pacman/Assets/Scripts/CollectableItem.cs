﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class CollectableItem : MonoBehaviour
{
    public Effect effect;

    protected virtual void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Pacman" || other.gameObject.tag == "Ghost")
        {
            var playerScript = other.GetComponent<ItemCollector>();

            //This is where you would pass the item to the Player script
            playerScript.OnPickupItem(this);
        }
    }
}
