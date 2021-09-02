using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShootingComponent : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject firstMount;
    private GameObject secondMount;
    private bool shootingFirstMount = false;
    private bool shootingSecondMount = false;
    IEnumerator Start()
    {
        yield return new WaitForSeconds(0.2f);
        foreach (Transform t in transform) {
            if (t.gameObject.name == "0") {
                firstMount = t.gameObject;
            }
            if (t.gameObject.name == "1") {
                secondMount = t.gameObject;
            }
        }
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            shootingFirstMount = true;
        }
        if (Input.GetMouseButtonUp(0)) {
            shootingFirstMount = false;
        }
        if (Input.GetMouseButtonDown(1)) {
            shootingSecondMount = true;
        }
        if (Input.GetMouseButtonUp(1)) {
            shootingSecondMount = false;
        }
        if (shootingFirstMount && firstMount != null) {
            firstMount.GetComponent<MountComponent>().Shoot();
        }
        if (shootingSecondMount && secondMount != null) {
            secondMount.GetComponent<MountComponent>().Shoot();
        }
    }
}
