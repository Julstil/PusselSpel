using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class evilFeild : MonoBehaviour
{
    [SerializeField]
    public string[] acceptedTag;
    [SerializeField]
    string[] notAcceptedTag;

    [Range(5, 2000)]
    public int pushBackX = 93;
    [Range(5, 2000)]
    public int pushBackY = 61;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        foreach (string item in notAcceptedTag) //För varje objekt som har en tag som är lika dan som en i notAcceptedTag arayn kommer detta hända vid kollision - Edvin
        {
            if (collision.tag == item) //Kollar om tagen är samma som en i notAcceptedTag - Edvin
            {
                var playerPM = collision.GetComponent<PlayerMovement>(); // skapar en variabel för objektets/spelarens PlayerMovement kod - Edvin
                playerPM.isActive = false; // Gör boolen isActive till falskt - Edvin
                collision.GetComponent<Health>().hp--; // Refererar till spelarens Health kod och säger att hp variabeln ska minska med 1 - Edvin
                var playerRB = collision.GetComponent<Rigidbody2D>(); // skapar en variabel för objektets/spelarens RigidBody - Edvin
                if (playerRB.velocity.y < 1) // Kollar ifall objektets/spelarens hastighet är mindre än 1 - Edvin 
                {
                    playerRB.velocity = new Vector2(playerRB.velocity.x, playerRB.velocity.y + 1); // i så fall plussar vi på 1 i y led - Edvin
                    /* Fixar en bug då addForce nedanför inte ville funka på ett smooth och bra sätt då den innan hackade tillbaka.
                     * Ger inte objektet/spelaren en bost upp med pushbackY som man kanske kan tro, 1 är ganska litet och blir riktat nedåt då vi
                     * vänder på hastigheten i nästa kod. - Edvin
                     */
                }

                playerRB.AddForce(new Vector2(-playerRB.velocity.x * pushBackX, -playerRB.velocity.y * pushBackY));
                /* Vänder på objektets/spelarens hastighet och knuffar tillbaka objektet/spelaren med AddForce genom att multiplicera den nuvarande
                 * hastigheten med variablarna pushBackX och pushBackY. - Edvin
                 */

                playerPM.Reenable(); // Sätter igång Reenable funktionen i PlayerMovement koden - Edvin
            }
        }
    }
}
