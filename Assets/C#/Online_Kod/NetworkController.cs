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
        if (Menu.singlePlayer == false)
        {
            startbutton.interactable = false;
            PhotonNetwork.ConnectUsingSettings();
            print("Connecting...");
        }
    }

    public override void OnConnectedToMaster()
    {
        if (Menu.singlePlayer == false)
        {
            print("Connected to server in " + PhotonNetwork.CloudRegion);
            startbutton.interactable = true;
            PhotonNetwork.AutomaticallySyncScene = true;
        }
    }

    public void setUserName()
    {
        if (Menu.singlePlayer == false)
        {
            PhotonNetwork.LocalPlayer.NickName = nameField.text;
        }
    }
    //"if (Menu.singlePlayer == false)" gör att online koden aktiveras. - Daniel
}
