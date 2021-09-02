using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Player : MonoBehaviour
{
    [System.NonSerialized]
    public string firstMountName = "Minigun";
    [System.NonSerialized]
    public string secondMountName = "Cannon";
    [System.NonSerialized]
    public int level = 1;
    public int startHealth = 100;
    [System.NonSerialized]
    public float currentHealth;
    void Start() 
    {
        LoadPlayer();
        currentHealth = startHealth;
    }
    void Update() 
    {
        if(Input.GetKeyDown(KeyCode.K)){
            SavePlayer();
        }
    }
    public void LoadPlayer() 
    {
        PlayerData pd = SaveSystem.LoadPlayer();
        firstMountName = pd.firstMountName;
        secondMountName = pd.secondMountName;
        level = pd.level;
    }
    public void TakeDamage(float damage) {
        currentHealth -= damage;
        if (currentHealth <= 0) {
            Die();
        }
    }
    void Die() {
        SceneManager.LoadScene("StartScene");
    }
    public void SavePlayer() 
    {
        SaveSystem.SavePlayer(this);
    }
}