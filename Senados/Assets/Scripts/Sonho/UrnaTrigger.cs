using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UrnaTrigger : MonoBehaviour
{

    public bool animationOn;
    public GameObject zoom;
    private GameObject player;

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Player"){
            animationOn = true;
            zoom.SetActive(true);
            player = other.gameObject;
            player.SetActive(false);
            Destroy(gameObject);

        }
    }

    // Start is called before the first frame update
    void OnEnable()
    {
    }


    // Update is called once per frame
    void FixedUpdate()
    {
    }
}
