using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthbarcontroller : MonoBehaviour
{
    private Image healthBar;
    Player player;
    void Start() {
        healthBar = GetComponent<Image>();
        player = FindObjectOfType<Player>();
    }
    void Update() {
        healthBar.fillAmount = player.currentHealth / player.startHealth;
    }
}
