using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUpField : evilFeild
{
    public float forceup;
    private void OnTriggerStay2D(Collider2D collision)
    {
        foreach (string item in acceptedTag)
	    {
            if (collision.tag == item)
            {
                float dist = Vector3.Distance(transform.position, collision.transform.position);
                dist = Mathf.Clamp(dist, 1, 40);
                var playerRB = collision.GetComponent<Rigidbody2D>();
                playerRB.AddForce(new Vector2(0, forceup*dist));
            }
	    }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        foreach (string item in acceptedTag)
        {
            if (collision.tag == item)
            {
                var playerRB = collision.GetComponent<Rigidbody2D>();
                playerRB.velocity = playerRB.velocity * new Vector2(1, 0.3f);
            }
        }
    }
}
