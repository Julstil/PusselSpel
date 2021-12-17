using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public static bool singlePlayer;

    // Start is called before the first frame update
    void Start()
    {
        singlePlayer = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("Level"); //Laddar in scenen "Level" om man trycker på Space i menyn. Scenen laddas in med "singlePlayer" boolen som true, det gör att spelet är i singleplayer läge. - Daniel
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            singlePlayer = false;
            SceneManager.LoadScene("Level"); //Laddar in scenen "Level" om man trycker på Space i menyn. Scenen laddas in med "singlePlayer" boolen som false, det gör att spelet inte är i singleplayer läge, den kommer vara i online multiplayer läge. - Daniel
        }

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            Application.Quit(); //Stänger ner programmet om man trycker på shift i menyn. - Daniel
        }
    }
}
