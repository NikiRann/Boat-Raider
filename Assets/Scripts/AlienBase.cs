using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienBase : MonoBehaviour
{
    [SerializeField]
    private float startHealth;
    private float currentHealth;

    public GameObject finishView;

    void Start() {
        currentHealth = startHealth;
    }

    public void TakeDamage(float damage) {
        
        currentHealth -= damage;
        if (currentHealth <= 0) {
           
            LevelCompleted();
        }
    }
    void LevelCompleted() {
        GetComponent<SpriteRenderer>().enabled = false;
        finishView.SetActive(true);
    }
}
