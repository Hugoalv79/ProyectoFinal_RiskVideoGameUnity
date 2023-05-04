using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour{
    // Tiempo en segundos
    private float timer = 60;
    public TextMeshProUGUI textoTimer;
    private int minutos, segundos, centecimas;

    public GameObject gameController; // variable pública para la referencia al objeto GameController
    private GameController gameControllerScript; // variable privada para el script del GameController

    private void Start(){
        gameControllerScript = gameController.GetComponent<GameController>();
    }
    private void Update(){
        if(gameControllerScript.debeContinuar && timer >= 0){
            timer -= Time.deltaTime;
            if(timer < 0){
                gameControllerScript.debeContinuar = false;
                timer = 0;
                gameControllerScript.finGame(); // llamada a la función FinGame() del script GameController
            }
            minutos = (int)(timer / 60f);
            segundos = (int)(timer - minutos * 60f);
            centecimas = (int)((timer - (int)timer) * 100f);
            textoTimer.text = string.Format("{0:00}:{1:00}:{2:00}", minutos, segundos, centecimas);  
        }
    }
}