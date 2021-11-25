using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour, Imovable
{

    public float speed = 0.5f;

    private Transform target;

   public void moveObject()
   {
        //Vector3.MoveTowards
   }

}

public interface Imovable
{
    void moveObject();
}
