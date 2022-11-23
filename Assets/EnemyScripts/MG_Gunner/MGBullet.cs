using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MGBullet : MonoBehaviour
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
