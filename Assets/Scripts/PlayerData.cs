using System.Collections.Generic;
using System.Collections;
using UnityEngine;

[System.Serializable]
public class PlayerData {
    public string firstMountName;
    public string secondMountName;
    public int level;
    public PlayerData(Player player) {
        firstMountName = player.firstMountName;
        secondMountName = player.secondMountName;
        level = player.level;
    }
}
