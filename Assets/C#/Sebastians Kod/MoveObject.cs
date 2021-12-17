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
        //Säger vart objektet ska, hastigheten, maxdistansen samt ser till så att inget knas händer så att den stannar när den har kommit till destinationen
        Vector3 directionToMove = destination.position - target.position; 
        directionToMove = directionToMove.normalized * Time.deltaTime * speed;
        float maxDistance = Vector3.Distance(destination.position, target.position); 
        target.position = target.position + Vector3.ClampMagnitude(directionToMove, maxDistance); 
        child.Open(); //Edvin
    }
}
