using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MendigoController : MonoBehaviour
{

    public bool animationOn;
    private Transform cameraTransform;

    private void OnEnable() {
        animationOn = true;
        cameraTransform = GameObject.Find("Main Camera").transform;
        GameObject.Find("SonhoTrigger1").GetComponent<MendigoTrigger>().animationOn = true;

    }
    /// <summary>
    /// This function is called when the behaviour becomes disabled or inactive.
    /// </summary>
    void OnDisable()
    {
        GameObject.Find("SonhoTrigger1").GetComponent<MendigoTrigger>().animationOn = false;
    }

    // Update is called once per frame
    void Update()
    {
        cameraTransform.position = new Vector3(cameraTransform.position.x, cameraTransform.position.y);
        if(animationOn == false){
            gameObject.SetActive(false);
        }
    }
}
