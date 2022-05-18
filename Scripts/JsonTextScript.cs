using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class JsonTextScript : MonoBehaviour
{
    private void Awake()
    {
        //Json yazdırma:
        Player player1 = new Player("player1", 100, 20);
//Debug.Log(JsonUtility.ToJson(player1));*/
        string json = JsonUtility.ToJson(player1, true);
        //File.WriteAllText(Application.dataPath + "/Players" + player1.userName + ".json", json);
        File.WriteAllText(Application.dataPath + "/Scenes/JSON_System/Players/" + player1.userName + ".json", json);
    }    
}
