using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuManagerTemp : MonoBehaviour
{
    public void Reiniciar(){
        SceneManager.LoadScene("LoaderGame1");
    }
    public void Salir(){
        SceneManager.LoadScene("Main_menu");
    }
}
