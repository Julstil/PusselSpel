using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{

    public float speed = 1.0f;

    public Vector3 target;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.transform.tag == "Lever")
        {
            Move();
        }
    }

    private void Move()
    {

        if (Input.GetKeyDown(KeyCode.E))
        {
            Vector3 directionToMove = target - transform.position;
            directionToMove = directionToMove.normalized * Time.deltaTime * speed;
            float maxDistance = Vector3.Distance(transform.position, target);
            transform.position = transform.position + Vector3.ClampMagnitude(directionToMove, maxDistance);
        }
    }
}
