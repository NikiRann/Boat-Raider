using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileComponent : MonoBehaviour
{
    [SerializeField]
    private float damage;
    void OnCollisionEnter2D(Collision2D collision)
    {     
        if (collision.collider.tag == "Turret") {
            collision.collider.GetComponent<LandTurretComponent>().TakeDamage(damage); 
        }
        if (collision.collider.tag == "Player") {
            collision.collider.GetComponent<Player>().TakeDamage(damage); 
        }
        if (collision.collider.tag == "AlienBase") {
            collision.collider.GetComponent<AlienBase>().TakeDamage(damage); 
        }
        GameObject.Destroy(gameObject);  
    }
}
