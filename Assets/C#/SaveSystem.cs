using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class SaveSystem : MonoBehaviour
{
    [SerializeField] private GameObject unitGameObject;
    private IUnit unit;

    private void Awake() //Hämtar IUnit Kod
    {
        unit = unitGameObject.GetComponent<IUnit>(); 
        PlayerPrefs.DeleteAll(); //Raderar allt i PlayerPrefs
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F)) //Spara
        {
            Save();
        }
        if (Input.GetKeyDown(KeyCode.L)) //Ladda
        {
            Load();
        }
    }

    private void Save()
    {
        //Sparar spelarens position
        Vector3 playerPosition = unit.GetPosition();
        PlayerPrefs.SetFloat("PlayerPositionX", playerPosition.x);
        PlayerPrefs.SetFloat("PlayerPositionY", playerPosition.y);
        PlayerPrefs.Save();
    }

    private void Load()
    {
        //Laddar spelarens sparade position
        if (PlayerPrefs.HasKey("playerPositionX"))
        {
            float playerPositionX = PlayerPrefs.GetFloat("playerPositionX");
            float playerPositionY = PlayerPrefs.GetFloat("playerPositionY");
            Vector3 playerPosition = new Vector3(playerPositionX, playerPositionY);

            unit.SetPosition(playerPosition);
        }
        else
        {

        }
    }
}