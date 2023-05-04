using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayOB : MonoBehaviour{
    private bool visited;
    [SerializeField]
    private AudioSource fuente;
    [SerializeField]
    private AudioClip musica;
    // Start is called before the first frame update
    void Start(){
        visited = false;
        fuente.clip = musica;
    }

    public void ReproducirMusica(){
        if(!visited){
            visited = true;
            fuente.Play();
            // Encontrar el objeto con la etiqueta "GameController"
            GameObject gameController = GameObject.FindWithTag("GameController");
            // Llamar la función "SumarPuntos" del objeto GameController
            if(gameController != null){
                gameController.GetComponent<GameController>().sumarPuntos();
            }
        }
    }

   
}