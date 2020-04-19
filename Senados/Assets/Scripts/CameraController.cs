using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    private GameObject player;

    /// <summary>
    /// This function is called when the object becomes enabled and active.
    /// </summary>
    void OnEnable()
    {
        player = GameObject.Find("Player");        
    }

    // Update is called once per frame
    private void Update()
    {
        if(player.transform.position.x > -8.68 && player.transform.position.x < 8.61){
            print(player.transform.position.x);
            transform.position = new Vector3(player.transform.position.x, transform.position.y, transform.position.z);
        }
        else{
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        }
        if(player.transform.position.y > -4 && player.transform.position.y < -2.21){
            transform.position = new Vector3(transform.position.x, player.transform.position.y+3, transform.position.z);
        }
        else{
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        }
    }
}
