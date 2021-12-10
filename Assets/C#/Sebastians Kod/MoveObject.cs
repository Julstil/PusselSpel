using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour, IBtn
{
    public float speed = 1.0f;
    public Transform target;  
    public Transform destination;
    public MoveBtnChild child;

    public void Btn()
    {
        Vector3 directionToMove = destination.position - target.position; //Berättar vilket håll objektet ska röra sig mot
        directionToMove = directionToMove.normalized * Time.deltaTime * speed; //Säger hastigheten
        float maxDistance = Vector3.Distance(destination.position, target.position); //Säger maxdistansen
        target.position = target.position + Vector3.ClampMagnitude(directionToMove, maxDistance); //
        child.Open();
    }
}
