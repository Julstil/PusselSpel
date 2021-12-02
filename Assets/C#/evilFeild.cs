using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class evilFeild : MonoBehaviour
{
    //public GameObject red;
   // public GameObject blue;
    float time = 0;
    public float enableScriptTime = 0.2f;

    [SerializeField]
    string[] acceptedTag;
    [SerializeField]
    string[] notAcceptedTag;

    [Range(0, 2000)]
    public int pushBackX;
    [Range(5, 2000)]
    public int pushBackY;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        foreach (string item in notAcceptedTag)
        {
            if (collision.tag == item)
            {
                var redPM = collision.GetComponent<PlayerMovement>();
                redPM.isActive = false;
                collision.GetComponent<Health>().hp--;
                var redRB = collision.GetComponent<Rigidbody2D>();
                if (redRB.velocity.y < 1)
                {
                    redRB.velocity = new Vector2(redRB.velocity.x, redRB.velocity.y + 1);
                }
                redRB.AddForce(new Vector2(-redRB.velocity.x * pushBackX, -redRB.velocity.y * pushBackY));
                redPM.Reenable();
            }
        }
        
    }
}
