using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    This class makes the enemy follow the player. It also deals with rotating the enemy according the player, how fast 
        the enemy shoots and moves, the enemy's "detection" zone, and the enemy's shooting zone.   
*/

public class EnemyFollowPlayer : MonoBehaviour
{
    public float speed; // speed of enemy
    private Transform player;
    public float lineOfSite; 
    public float shootingRange; 
    public GameObject bullet; // bullet prefab
    public GameObject bulletParent; // firepoint of enemy
    public float fireRate = 1f;
    private float nextFireTime; 
    private Rigidbody2D rb; // needed for rotation of enemy

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>(); 
        player = GameObject.FindGameObjectWithTag("Player").transform; 
        
    }

    // Update is called once per frame
    void Update()
    {
        // Rotation of enemy //
        Vector2 direction = player.position - transform.position; 
        float angle = Mathf.Atan2(direction.y,direction.x) * Mathf.Rad2Deg; 
        rb.rotation = angle; 

        // Logic to follow player and shoot player // 
        float distanceFromPlayer = Vector2.Distance(player.position, transform.position); 
        if(distanceFromPlayer < lineOfSite && distanceFromPlayer > shootingRange){
            transform.position = Vector2.MoveTowards(this.transform.position, player.position, speed * Time.deltaTime);
        }else if(distanceFromPlayer <= shootingRange && nextFireTime < Time.time){
            Instantiate(bullet, bulletParent.transform.position, Quaternion.identity);
            nextFireTime = Time.time + fireRate;  
        }
    }

    // Just a method to visualize the shooting and line of site range in game (Not necessary but helpful)
    private void OnDrawGizmosSelected(){
        Gizmos.color = Color.green; 
        Gizmos.DrawWireSphere(transform.position, lineOfSite);
        Gizmos.DrawWireSphere(transform.position, shootingRange);  
    }
}
