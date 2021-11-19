using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;

public class NetworkController : MonoBehaviourPunCallbacks
{
    [SerializeField]
    Button startbutton;
    [SerializeField]
    InputField nameField;

    // Start is called before the first frame update
    void Start()
    {
        startbutton.interactable = false;
        PhotonNetwork.ConnectUsingSettings();
        print("Connecting...");
    }

    public override void OnConnectedToMaster()
    {
        print("Connected to server in " + PhotonNetwork.CloudRegion);
        startbutton.interactable = true;
        PhotonNetwork.AutomaticallySyncScene = true;
    }

    public void setUserName()
    {
        PhotonNetwork.LocalPlayer.NickName = nameField.text;
    }
}
