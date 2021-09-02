using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LandTurretComponent : MonoBehaviour
{
    [SerializeField]
    private float maxHealth;
    private float health;
    [SerializeField]
    private List<Transform> barrels;
    [SerializeField]
    private GameObject bulletPrefab;
    [SerializeField]
    private float bulletSpeed;
    [SerializeField]
    private Animator animator;
    [SerializeField]
    private CircleCollider2D playerDetector;
    private bool isPlayerDetected = false;
    private Transform playerLocation;
    
    void Start() {
        health = maxHealth;
    }
    public void TakeDamage(float damage) {
        health -= damage;
        if (health <= 0) {
            animator.SetTrigger("Exploding");
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player") 
        {
            isPlayerDetected = true;
            playerLocation = other.transform;
        }    
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player") 
        {
            isPlayerDetected = false;
        }    
    }
    void Update()
    {
        if (isPlayerDetected) 
        {
            float desiredAngle = Mathf.Atan2(transform.position.x - playerLocation.position.x,  transform.position.y - playerLocation.position.y) * 180 / Mathf.PI;
            transform.rotation = Quaternion.Euler(new Vector3(0, 0, -desiredAngle + 180));
            animator.SetBool("Shooting", true);
        } 
        else
        {
            animator.SetBool("Shooting", false);
        }
    }
    void Shoot() 
    {
        foreach (Transform t in barrels) {
            var bullet = Instantiate(bulletPrefab, t.position, transform.rotation);
            bullet.GetComponent<Rigidbody2D>().AddForce(transform.up * bulletSpeed);
        }
    }
    void Explode() {
        GameObject.Destroy(gameObject);
    }
}
