using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
    This class basically just allows the player to fire 
*/ 
public class Shooting : MonoBehaviour
{
    public Transform firePoint; 
    public GameObject bulletPrefab; 
    public float bulletForce = 20f; 
    
    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1")){ // currently just using left click on mouse to fire, can be changed in input settings.
            Shoot(); 
        }
    }

    void Shoot(){
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>(); 
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
    }
}
