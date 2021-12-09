using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class MultiplayerLobby : MonoBehaviourPunCallbacks
{
    public int roomSize;

    // Start is called before the first frame update
    public void JoinRoom()
    {
        if (Menu.singlePlayer == false)
        {
        PhotonNetwork.JoinRandomRoom();
        print("Trying to join...");
        }
    }

    public override void OnJoinRandomFailed(short returnCode, string message)
    {
        if (Menu.singlePlayer == false)
        {
            CreateRoom();
        }
    }

    // Update is called once per frame
    void CreateRoom()
    {
        if (Menu.singlePlayer == false)
        {
            print("Creating room...");
            int RandomRoomNumber = Random.Range(0, 100000);
            print(RandomRoomNumber);

            RoomOptions options = new RoomOptions()
            {
                IsVisible = true,
                IsOpen = true,
                MaxPlayers = (byte)roomSize
            };
            PhotonNetwork.CreateRoom("Room" + RandomRoomNumber, options);
        }
    }

    public override void OnCreateRoomFailed(short returnCode, string messege)
    {
        if (Menu.singlePlayer == false)
        {
            CreateRoom();
        }
    }

    public void Cancel()
    {
        if (Menu.singlePlayer == false)
        { 
            PhotonNetwork.LeaveRoom();
        }
    }
    //"if (Menu.singlePlayer == false)" gör att online koden aktiveras. - Daniel
}
