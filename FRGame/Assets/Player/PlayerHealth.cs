using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 3;
    private int currentHealth;

    public HealthBar healthBar;

    void Start()
    {
        // getting saved health
        currentHealth = PlayerPrefs.GetInt("health"); 

        // fix for health being zero at the start of the level
        if (currentHealth <= 0)
        {
            currentHealth = maxHealth;
        }
        healthBar.SetHealth(currentHealth);
  
    }

    void Update()
    {
        healthBar.SetHealth(currentHealth);
        PlayerPrefs.SetInt("health", currentHealth);    // setting health to find it later when scenec
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            Damage(1);
        }


    }

    // simple function to do damage
    void Damage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }
}
