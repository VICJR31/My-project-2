using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
    This class is the logic for the enemy bullet prefab. It deals with how the bullet object should move in the game. Right now, it just moves in one direction.
    This is because it calculates the distance from player once every frame. It also handles collusion, right now the object 
        just gets destroyed when it encouters a collider (no damage is applied to anything). 
*/

public class EnemyBullet : MonoBehaviour
{
    GameObject target; 
    public float speed; 
    Rigidbody2D bulletRB;
    public int damage = 20; 

    // Start is called before the first frame update
    void Start() 
    {
        bulletRB = GetComponent<Rigidbody2D>(); 
        target = GameObject.FindGameObjectWithTag("Player"); 
        Vector2 moveDir = (target.transform.position - transform.position).normalized * speed;
        bulletRB.velocity = new Vector2(moveDir.x, moveDir.y); 
        Destroy(this.gameObject,2);
    }
    void OnTriggerEnter2D (Collider2D hitInfo){
        Debug.Log(hitInfo.name); // prints out what the bullet collied with in console
        Player player = hitInfo.GetComponent<Player>(); 
        if(player != null){
            player.TakeDamage(damage); 
        }
        Destroy(this.gameObject); 
    }
}
