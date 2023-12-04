using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Se encarga de actualizar la velocidad con el tiempo
public class ActualizadorVelocidad
{
    // Actualizar la velocidad
    public float ActualizaVelocidad(float initialVelocity, float acceleration)
    {
        // Calcular la nueva velocidad teniendo en cuenta el tiempo
        return initialVelocity + acceleration * Time.deltaTime;
    }
}
