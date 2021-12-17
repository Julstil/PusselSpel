using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IUnit
{
    //Kod för sparande av PlayerPrefs
    Vector3 GetPosition();
    void SetPosition(Vector3 position); 
}
