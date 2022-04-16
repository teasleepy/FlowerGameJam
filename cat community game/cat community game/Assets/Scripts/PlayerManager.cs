using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.IO;

public class PlayerManager : MonoBehaviour
{
    public int coinCount;

    public void PickUpItem()
    {
        coinCount++;


    }

    private void Update()
    {
        //body.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, body.velocity.y);

        if (Input.GetKeyDown(KeyCode.S))
        {
            Save();
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            Load();
        }
    }

    private void Save()
    {
        string saveStringCoin = "" + coinCount;

        //File.WriteAllText(Application.dataPath + "/save.txt", "COINtest/n", saveStringCoin);
        File.WriteAllText(Application.dataPath + "/save.txt", saveStringCoin);
    }

    private void Load()
    {
        string saveStringCoin = File.ReadAllText(Application.dataPath + "/save.txt");
        //CMDbug.TextPopupMouse("Loaded: " + saveStringCoin);

        coinCount = int.Parse(saveStringCoin);

    }
}
