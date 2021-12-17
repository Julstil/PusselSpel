using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameClear : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("Menu"); //Laddar in scenen "Menu" om man trycker på Space i menyn. Scenen laddas in med "singlePlayer" boolen som true, det gör att spelet är i singleplayer läge. - Daniel
        }
    }
}
