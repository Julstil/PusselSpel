using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using Photon.Pun;
public class GameSetup : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (Menu.singlePlayer == false)
        {
            CreatePlayer();
        }
    }

    // Update is called once per frame
    void CreatePlayer()
    {
        if (Menu.singlePlayer == false)
        {

        }
        if (PhotonNetwork.IsMasterClient)
        {
            PhotonNetwork.Instantiate(Path.Combine("Prefabs", "Blue Cube"), Vector3.right, Quaternion.identity);
        }

        if (!PhotonNetwork.IsMasterClient)
        {
            PhotonNetwork.Instantiate(Path.Combine("Prefabs", "Green Cube"), Vector3.left, Quaternion.identity);
        }
    }
    //"if (Menu.singlePlayer == false)" gör att online koden aktiveras. - Daniel
}
