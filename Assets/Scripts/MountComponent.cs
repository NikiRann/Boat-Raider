using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MountComponent : MonoBehaviour
{
    [SerializeField]
    private bool lookingAtMouse = true;
    [SerializeField]
    private Transform mainTarget;
    [SerializeField]
    private Transform shootingPoint;
    [SerializeField]
    private float shootingInterval = 10f;
    [SerializeField]
    private GameObject bulletPrefab;
    [SerializeField]
    private float bulletSpeed = 140f;
    private float timeSinceLastShot = 0f;
    void Start()
    {
        
    }
    void Update()
    {
        timeSinceLastShot += Time.deltaTime;
        LookAtTarget();
    }
    public void Shoot() {
        if (timeSinceLastShot >= shootingInterval) {
            timeSinceLastShot = 0;
            var bullet = Instantiate(bulletPrefab, shootingPoint.position, transform.rotation);
            bullet.GetComponent<Rigidbody2D>().AddForce(transform.up * bulletSpeed);
        }
    }
    void LookAtTarget() {
        Vector3 target;
        if (lookingAtMouse) {
            target = Input.mousePosition;
        }
        else {
            target = mainTarget.position;
        }
        Vector3 objectPos = Camera.main.WorldToScreenPoint (transform.position);
        target.x = target.x - objectPos.x;
        target.y = target.y - objectPos.y;
 
        float angle = Mathf.Atan2(target.y, target.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle - 90));
    }

}
