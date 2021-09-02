using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasController : MonoBehaviour
{
    [SerializeField]
    private Transform playerBoat;
    [SerializeField]
    private Transform levelCenter;
    [SerializeField]
    private GameObject compassImage;

    void Update()
    {
        float compassRotation = Mathf.Atan2(playerBoat.position.x - levelCenter.position.x, playerBoat.position.y - levelCenter.position.y) * 180 / Mathf.PI;
        compassImage.transform.rotation = Quaternion.Euler(new Vector3(0,0,- (compassRotation - 90)));
    }

    public void QuitToMainScreen() {
        SceneManager.LoadScene("StartScene");
    }
}
