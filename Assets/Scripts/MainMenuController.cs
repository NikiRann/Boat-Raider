using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    [SerializeField]
    private GameObject buttonMountText1;
    [SerializeField]
    private GameObject buttonMountText2;
    [SerializeField]
    private GameObject mountsView;
    private PlayerData pb;
    private int changingMount;

    void Start() {
        pb = SaveSystem.LoadPlayer();
        if (pb.firstMountName != "") {
            buttonMountText1.GetComponent<UnityEngine.UI.Text>().text = pb.firstMountName;
        }
        if (pb.secondMountName != "") {
            buttonMountText2.GetComponent<UnityEngine.UI.Text>().text = pb.secondMountName;
        }
    }
    public void MountButton1Pressed() {
        changingMount = 1;
        mountsView.SetActive(true);
    }
    public void MountButton2Pressed() {
        changingMount = 2;
        mountsView.SetActive(true);
    }
    public void MinigunButtonPressed() {
        mountsView.SetActive(false);
        if (changingMount == 1) {
            pb.firstMountName = "Minigun";
            Player newPlayer = new Player();
            newPlayer.firstMountName = pb.firstMountName;
            newPlayer.secondMountName = pb.secondMountName;
            newPlayer.level = pb.level;
            SaveSystem.SavePlayer(newPlayer); 
            Start();
        }
        if (changingMount == 2) {
            pb.secondMountName = "Minigun";
            Player newPlayer = new Player();
            newPlayer.firstMountName = pb.firstMountName;
            newPlayer.secondMountName = pb.secondMountName;
            newPlayer.level = pb.level;
            SaveSystem.SavePlayer(newPlayer); 
            Start();
        }
    }
    public void CannonButtonPressed() {
        mountsView.SetActive(false);
        if (changingMount == 1) {
            pb.firstMountName = "Cannon";
            Player newPlayer = new Player();
            newPlayer.firstMountName = pb.firstMountName;
            newPlayer.secondMountName = pb.secondMountName;
            newPlayer.level = pb.level;
            SaveSystem.SavePlayer(newPlayer); 
            Start();
        }
        if (changingMount == 2) {
            pb.secondMountName = "Cannon";
            Player newPlayer = new Player();
            newPlayer.firstMountName = pb.firstMountName;
            newPlayer.secondMountName = pb.secondMountName;
            newPlayer.level = pb.level;
            SaveSystem.SavePlayer(newPlayer); 
            Start();
        }
    }

    public void Level1ButtonPressed() {
        SceneManager.LoadScene("Level1");
    }
}
