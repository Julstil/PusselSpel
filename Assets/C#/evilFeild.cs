using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class evilFeild : MonoBehaviour
{
    public GameObject red;
    public GameObject blue;

    [SerializeField]
    string[] acceptedTag;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        foreach (string item in acceptedTag)
        {
            if (collision.tag == item)
            {
                
            }
        }
        
    }
}
