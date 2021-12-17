using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Orb2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Tom") //Måste byta tag till både "Tom" och "Bob" tagsen. - Daniel
        {
            SceneManager.LoadScene("GameClear");
        }
    }
}
