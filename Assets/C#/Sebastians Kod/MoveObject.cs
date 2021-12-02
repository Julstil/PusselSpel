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
        Vector3 directionToMove = destination.position - target.position; //Berättar vilket håll objektet ska röra sig mot
        directionToMove = directionToMove.normalized * Time.deltaTime * speed; //Säger hastigheten
        float maxDistance = Vector3.Distance(destination.position, target.position); //Säger maxdistansen
        target.position = target.position + Vector3.ClampMagnitude(directionToMove, maxDistance); //
    }
}
