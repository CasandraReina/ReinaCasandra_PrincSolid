using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

// Clase para incrementar el contador y verificar la victoria
public class Contador : MonoBehaviour
{
    public TextMeshProUGUI contadorText;
    private IEscenaGanador ganador; 
    public int contador = 0; // Variable para almacenar el valor actual del contador.

    void Start()
    {
        // Inicializa de la variable ganador con una nueva instancia de la clase Ganador, pasando un nuevo EscenaManager.
        ganador = new EscenaGanador(new EscenaManager());
    }

    //IncrementarContador que recibe una cantidad para aumentar el contador.
    public void IncrementarContador(int cantidad)
    {
        contador += cantidad; // Aumenta el contador por la cantidad proporcionada.

        if (contador >= 30)  // Si el contador es mayor o igual a 30.
        {
            ganador.EscenaGanar();  // Llama al metodo EscenaGanar() de la interfaz IEscenaGanador.
        }
    }
}
