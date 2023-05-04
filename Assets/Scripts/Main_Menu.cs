using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main_Menu : MonoBehaviour{
    public void Start1_Button(){
        SceneManager.LoadScene("LoaderGame1");
    }

    public void Start2_Button(){
        SceneManager.LoadScene("FallingObjScene");
    }

    public void QuitButton(){
        Application.Quit();
    }
}
