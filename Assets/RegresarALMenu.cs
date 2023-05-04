using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RegresarALMenu : MonoBehaviour{
    public void BackToMenu_Button(){
        SceneManager.LoadScene("Main_Menu");
    }
}
