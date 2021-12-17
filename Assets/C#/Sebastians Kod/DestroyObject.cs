using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    private void DestroyAllObjectsOfType<T>() where T : Component
    {
        T[] _objectList = FindObjectsOfType<T>(); //Hittar Objekt av T

        foreach (T _object in _objectList) //Förstör varje objekt av T 
        {
            if(Input.GetKeyDown(KeyCode.N & KeyCode.O))
            {
                Destroy(_object.gameObject);

            }
            else
            {
                DestroyImmediate(_object.gameObject);
            }
        }
    }
}
