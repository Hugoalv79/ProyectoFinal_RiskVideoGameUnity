using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour{
    private int puntos;
    [SerializeField]
    private int maxPuntos;
    private TextMeshProUGUI textMesh;
    private int vidaActual;
    public GameObject[] vidas;
    public bool debeContinuar = true;
    
    // MENUS
    [SerializeField]
    private GameObject menuGameOverWin;
    [SerializeField]
    private GameObject menuGameOverLose;

    // AUDIO
    public AudioSource audioSourceInicio; // variable pública para la referencia al componente AudioSource
    public AudioSource audioSourceWin;
    public AudioSource audioSourceLose1;
    public AudioSource audioSourceLose2;
    
    void Start(){
        audioSourceInicio.Play();
        vidaActual = 0;
        textMesh = GetComponent<TextMeshProUGUI>();
        puntos = 0;
        textMesh.text = puntos.ToString() + " / " + maxPuntos.ToString();
    }

    public void finGame(){
        audioSourceInicio.Stop();
        if(debeContinuar){
            // Llamar a Win Game
            audioSourceWin.Play();
            debeContinuar = false;
            menuGameOverWin.SetActive(true);
        }
        else{
            // Llamar a Lose Game
            audioSourceLose1.Play();
            StartCoroutine(ActivarMenuGameOverLoseDespuesDeReproducirMusica1()); // llama a la función que activa el menú y reproduce la música 2 después de que la música 1 termine
            menuGameOverLose.SetActive(true);
        }
        // Regresar aquí los datos a la API
    }

    public void sumarPuntos(){
        puntos++;
        textMesh.text = puntos.ToString() + " / " + maxPuntos.ToString();
        if(puntos == maxPuntos){
            finGame();
        }
    }
    public void restarVida(){ 
        vidas[vidaActual].SetActive(false);
        vidaActual++;
        if(vidaActual == 3){
            debeContinuar = false;
            finGame(); // llamada a la función FinGame() si se pierden todas las vidas
        } 
    }

    private IEnumerator ActivarMenuGameOverLoseDespuesDeReproducirMusica1(){
        yield return new WaitForSecondsRealtime((float)audioSourceLose1.clip.length); // espera a que la música 1 termine de reproducirse
        audioSourceLose2.Play();
    }
}