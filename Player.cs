using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Player
{
    public string userName;
    public int playerHealth;
    public int playerDamage;

    public Player(string userName, int playerHealth, int playerDamage)
    {
        this.userName = userName;
        this.playerHealth = playerHealth;
        this.playerDamage = playerDamage;
    }
}
