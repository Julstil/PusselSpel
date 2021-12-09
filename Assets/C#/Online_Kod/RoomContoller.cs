using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class RoomContoller : MonoBehaviourPunCallbacks
{
    [SerializeField]
    int sceneIndex;

    public override void OnEnable()
    {
        if (Menu.singlePlayer == false)
        {
            PhotonNetwork.AddCallbackTarget(this);
        }
    }

    public override void OnDisable()
    {
        if (Menu.singlePlayer == false)
        {
            PhotonNetwork.RemoveCallbackTarget(this);
        }
    }

    public override void OnJoinedRoom()
    {
        if (Menu.singlePlayer == false)
        {
            StartGame();
        }
    }

    void StartGame()
    {
        if (Menu.singlePlayer == false)
        {
            if (PhotonNetwork.IsMasterClient)
            {
                print("Starting Game...");
                PhotonNetwork.LoadLevel(sceneIndex);
            }
        }
    }
    //"if (Menu.singlePlayer == false)" gör att online koden aktiveras. - Daniel
}
