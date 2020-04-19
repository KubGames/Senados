using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MendigoTrigger : MonoBehaviour
{

    public bool animationOn;
    public GameObject zoom;
    private GameObject player;

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Player"){
            zoom.SetActive(true);
            player = other.gameObject;

        }
    }

    // Start is called before the first frame update
    void OnEnable()
    {
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        print(animationOn);
        if(animationOn){
            player.SetActive(false);

        }
        else{
            player.SetActive(true);
            zoom.SetActive(false);
            Destroy(gameObject);
        }
    }
}
