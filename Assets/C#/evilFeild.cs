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
    public int pushBackX;
    [Range(5, 2000)]
    public int pushBackY;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        foreach (string item in notAcceptedTag)
        {
            if (collision.tag == item)
            {
                var playerPM = collision.GetComponent<PlayerMovement>();
                playerPM.isActive = false;
                collision.GetComponent<Health>().hp--;
                var playerRB = collision.GetComponent<Rigidbody2D>();
                if (playerRB.velocity.y < 1)
                {
                    playerRB.velocity = new Vector2(playerRB.velocity.x, playerRB.velocity.y + 1);
                }
                playerRB.AddForce(new Vector2(-playerRB.velocity.x * pushBackX, -playerRB.velocity.y * pushBackY));
                playerPM.Reenable();
            }
        }
        
    }
}
