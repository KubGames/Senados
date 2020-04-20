using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MendigoController : MonoBehaviour
{

    public bool animationOn;
    private Transform cameraTransform;
    private AudioSource wind;

    private void OnEnable() {
        animationOn = true;

        //Objeto da camera
        cameraTransform = GameObject.Find("Main Camera").transform;

        //Component do wind
        wind = GameObject.Find("Background").GetComponent<AudioSource>();
        
        //Variável do animationOn
        GameObject.Find("SonhoTrigger1").GetComponent<MendigoTrigger>().animationOn = true;

        //Pause wind
        wind.Pause();
        
        //Play Bell
        GameObject.Find("Background").GetComponent<AudioController>().PlayBell();
    }
    /// <summary>
    /// This function is called when the behaviour becomes disabled or inactive.
    /// </summary>
    void OnDisable()
    {
        //Modificar variável animationOn
        GameObject.Find("SonhoTrigger1").GetComponent<MendigoTrigger>().animationOn = false;
        
        //Despausar Wind
        wind.UnPause();
    }

    // Update is called once per frame
    void Update()
    {

        
        //Posição da câmera
        cameraTransform.position = new Vector3(cameraTransform.position.x, cameraTransform.position.y);
        
        //Desativar Objeto
        if(animationOn == false){
            gameObject.SetActive(false);
        }
    }
}
