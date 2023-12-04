using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuntuacionActualizacion
{
    public void ActualizarPuntuacion(string tag, Contador contadorPuntos)
    {
        //Metodo para actualizar la puntuacion basado en la etiqueta del objeto de colision y el contador actual.

        switch (tag)
        {
            case "Rata":
                contadorPuntos.IncrementarContador(1);
                // Si la etiqueta es "Rata", incrementa el contador en 1.
                break;

            case "BigRata":
                contadorPuntos.IncrementarContador(2);
                // Si la etiqueta es "BigRata", incrementa el contador en 2.
                break;
        }
    }
}
