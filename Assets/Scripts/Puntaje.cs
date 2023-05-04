using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Puntaje : MonoBehaviour{
    // Start is called before the first frame update
    private int puntos;
    [SerializeField]
    private int maxPuntos;
    private TextMeshProUGUI textMesh;
    void Start(){
        textMesh = GetComponent<TextMeshProUGUI>();
        puntos = 0;
        textMesh.text = puntos.ToString() + " / " + maxPuntos.ToString();
    }

    public void sumarPuntos(){
        puntos++;
        textMesh.text = puntos.ToString() + " / " + maxPuntos.ToString();
    }
}
