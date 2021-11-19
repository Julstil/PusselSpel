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
        PhotonNetwork.JoinRandomRoom();
        print("Trying to join...");
    }

    public override void OnJoinRandomFailed(short returnCode, string message)
    {
        CreateRoom();
    }

    // Update is called once per frame
    void CreateRoom()
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

    public override void OnCreateRoomFailed(short returnCode, string messege)
    {
        CreateRoom();
    }

    public void Cancel()
    {
        PhotonNetwork.LeaveRoom();
    }

}
