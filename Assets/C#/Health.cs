using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public float hp;
    // Start is called before the first frame update
    void Start()
    {
        hp = 3;
    }

    // Update is called once per frame
    void Update()
    {
        if (hp <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); //Startar om scenen när man har 0 hp. - Daniel
        }
        if (hp > 3)
        {
            hp--; //Tar bort 1 hp om man har över 3. På så vis kan man ha 3 hp som mest. - Daniel
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Enemy")
        {
            hp--; //Tar bort 1 hp om man gör kontakt med ett objekt med en "Enemy" tag. - Daniel
        }

        if (collision.transform.tag == "Health")
        {
            hp++; //Lägger till 1 hp om man gör kontakt med ett objekt med en "Health" tag. - Daniel
            Destroy(collision.gameObject); //Förstör objekt som har en "Health" tag när spelaren gör kontakt med den. På så sätt kan man inte få hur mycket hp som helst från en collectable. - Daniel
        }
    }
}
