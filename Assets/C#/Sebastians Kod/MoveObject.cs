using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    public float speed = 1.0f;
    public Transform target;  
    public Transform destination;
    private void OnTriggerStay2D(Collider2D collision)
    {
        //Om dessa kriterier möts gör Move() koden sitt jobb.
        if (collision.transform.tag == "Player" && Input.GetKey(KeyCode.E)) 
        {
            Move();    
        }
    }
    private void Move()
    {
        //Koden säger till objektet vart den ska, hastigheten och maxdistansen.
        Vector3 directionToMove = destination.position - target.position;
        directionToMove = directionToMove.normalized * Time.deltaTime * speed;
        float maxDistance = Vector3.Distance(destination.position, target.position);
        target.position = target.position + Vector3.ClampMagnitude(directionToMove, maxDistance); 
    }
}
