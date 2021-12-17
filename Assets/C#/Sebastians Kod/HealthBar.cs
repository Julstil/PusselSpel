//Funkar inte

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HealthBar : MonoBehaviour
{

    public Image healthBar;
    public float currentHealth = 3f;
    public float maxHealth = 3f;
    Health Tom;

    Image image;

    void start()
    {
        //Hitta healthbar bilden, ge Tom Healthkoden
        healthBar = GetComponent<Image>();
        Tom = GetComponent<Health>();
    }

    public void health(float health)
    {
        Tom.hp = currentHealth; //Edvin
        image.fillAmount = currentHealth / maxHealth; //Bilden ändras beroende på hur mycket hp du har
    }

}
