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
    private void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.Space) ||Input.GetButton("Jump")||Input.GetButton("Submit")){
            GameObject.Find("Main Camera/Zoom_morador_de_rua").SetActive(false);
            GameObject.Find("Main Camera/Votação (1)_0").SetActive(false);
        }

        if(player.transform.position.x > -8.68 && player.transform.position.x < 8.61 ){
            transform.position = new Vector3(player.transform.position.x, transform.position.y, -8.47f);
        }
        else{
            transform.position = new Vector3(transform.position.x, transform.position.y, -8.47f);
        }
        if(player.transform.position.y > -4 && player.transform.position.y < -2.21){
            transform.position = new Vector3(transform.position.x, player.transform.position.y+3, -8.47f);
        }
        else{
            transform.position = new Vector3(transform.position.x, transform.position.y, -8.47f);
        }
    }
}
