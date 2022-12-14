using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tempEnemy : MonoBehaviour
{
    public int maxHealth = 100; 
    public int currentHealth;
    public HealthBar healthBar; 

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.setMaxHealth(maxHealth);  
    }

    public void TakeDamage (int damage){
        currentHealth -= damage; 
        healthBar.setHealth(currentHealth);
        if(currentHealth <= 0){
            Die(); 
        }
    }
    void Die(){
        Destroy(gameObject); 
    }
}
