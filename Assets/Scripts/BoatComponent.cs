using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatComponent : MonoBehaviour
{
    [SerializeField]
    private List<Transform> gunMountPositions = new List<Transform>();

    void Start()
    {
        Player player = gameObject.GetComponent<Player>();
        
        if (player.firstMountName != "") {
            var firstMount = Resources.Load<GameObject>(player.firstMountName);
            var firstMountObj = (Instantiate(firstMount, gunMountPositions[0].position, Quaternion.identity));

            firstMountObj.transform.parent = transform;  
            firstMountObj.transform.localScale = Vector3.one;  
            firstMountObj.name = "0";
        }

        if (player.secondMountName != "") {
            var secondMount = Resources.Load<GameObject>(player.secondMountName);
            var secondMountObj = (Instantiate(secondMount, gunMountPositions[1].position, Quaternion.identity));

            secondMountObj.transform.parent = transform;  
            secondMountObj.transform.localScale = Vector3.one; 
            secondMountObj.name = "1";    
        }     
    }
    void Update()
    {
        
    }
}
