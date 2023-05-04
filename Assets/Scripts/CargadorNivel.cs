using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CargadorNivel : MonoBehaviour{
    private int numeroScena;
    public AudioSource fuente;
    public AudioClip clip;
    public GameObject PantallaDeCarga;
    public Slider slider;

    void Start(){
        fuente.clip = clip;
        slider.value = 0.0f;
        numeroScena = Random.Range(1,5);
    }
    public void cargarNivel(int noHaceNada){
        StartCoroutine(CargarAsync());
    }

    IEnumerator CargarAsync(){
        fuente.Play();
        yield return new WaitForSeconds(8.5f);
        AsyncOperation Operacion = null;
        float ritmo = 1.0f / 8.0f; // dividir entre el número de actualizaciones
        float progreso = 0.0f;
        while(progreso < 1.0f){
            progreso += ritmo;
            slider.value = progreso;
            yield return new WaitForSeconds(0.25f);
        }

        switch (numeroScena){
            case 1:{
                Operacion = SceneManager.LoadSceneAsync("Game1_1");
                break;
            };

            case 2:{
                Operacion = SceneManager.LoadSceneAsync("Game1_2");
                break;
            }

            case 3:{
                Operacion = SceneManager.LoadSceneAsync("Game1_3");
                break;
            }
            case 4:{
                Operacion = SceneManager.LoadSceneAsync("Game1_4");
                break;
            }
            
            default:{
                break;
            }
        }
        yield return null;
        PantallaDeCarga.SetActive(false);
    }
}
