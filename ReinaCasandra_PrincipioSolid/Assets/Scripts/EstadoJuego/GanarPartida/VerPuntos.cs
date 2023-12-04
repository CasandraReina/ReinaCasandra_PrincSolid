using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

// Clase para actualizar la interfaz de usuario
public class VerPuntos : MonoBehaviour
{
    public Contador contadorPuntos;

    void Update()
    {
        if (contadorPuntos.contadorText != null)   //Si contadorText de contadorPuntos no es nulo.
        {
            // Asignacion del texto del contadorText al valor convertido a cadena del contador de contadorPuntos.
            contadorPuntos.contadorText.text = contadorPuntos.contador.ToString();
        }
    }
}

