using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HealthBar : MonoBehaviour
{

    private Image healthBar;
    public float currentHealth;
    private float maxHealth = 3f;
    Health Tom;

    Image image;

    void start()
    {
        //Hitta
        healthBar = GetComponent<Image>();
        Tom = GetComponent<Health>();
    }

    void update()
    {
        Tom.hp = currentHealth; 
        image.fillAmount = currentHealth / maxHealth;
    }

}
