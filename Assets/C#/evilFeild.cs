using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class evilFeild : MonoBehaviour
{
    public GameObject red;
    public GameObject blue;

    [SerializeField]
    string[] acceptedTag;
    [SerializeField]
    string[] notAcceptedTag;

    [Range(500, 2000)]
    public int pushBackX;
    [Range(5, 2000)]
    public int pushBackY;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        foreach (string item in notAcceptedTag)
        {
            if (collision.tag == item)
            {
                collision.GetComponent<Health>().hp--;
                var redRB = red.GetComponent<Rigidbody2D>();
                if (redRB.velocity.y < 1)
                {
                    redRB.velocity = new Vector2(redRB.velocity.x,redRB.velocity.y + 1);
                }
                redRB.AddForce(new Vector2(-redRB.velocity.x * pushBackX, -redRB.velocity.y * pushBackY));
            }
        }
        
    }
}
