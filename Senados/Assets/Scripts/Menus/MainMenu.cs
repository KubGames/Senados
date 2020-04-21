using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    
    public void Iniciar(){
        SceneManager.LoadScene(1);
    }

    public void Opções(){
        GameObject.Find("OpçõesMenu").SetActive(true);
        gameObject.SetActive(false);
    }

    public void Sair(){
        Application.Quit();
    }


}
