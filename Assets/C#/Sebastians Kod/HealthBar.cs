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

    void start()
    {
        //Hitta
        healthBar = GetComponent<Image>();
        Tom = FindObjectOfType<Health>();
    }

    void update()
    {
        currentHealth.Tom.Health;
        HealthBar.fillAmount = currentHealth / maxHealth;
    }

}
