using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    This is the logic for the bullet prefab. This logic is only for the player. 
    So far, it basically just applies damage on collusion to the named enemy object. I have a temporary object in game called "Enemy", the enemy object
        has a component named "tempEnemy" that has the enemy configurations. 
    Once the collusion is triggered, the bullet object is destroyed.
*/

public class Bullet : MonoBehaviour
{
    public int damage = 20; 

    void OnTriggerEnter2D (Collider2D hitInfo){
        Debug.Log(hitInfo.name); 

        // Change "tempEnemy" to enemy profile name
        tempEnemy enemy = hitInfo.GetComponent<tempEnemy>(); 
        if(enemy != null){
            enemy.TakeDamage(damage); 
        }
        MGGunner mggunner = hitInfo.GetComponent<MGGunner>(); 
        if(mggunner != null){
            mggunner.TakeDamage(damage); 
        }
        Destroy(this.gameObject); 
    }
}
