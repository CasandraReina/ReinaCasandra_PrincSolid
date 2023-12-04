using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Controlador principal que maneja el movimiento del objeto
public class RataController : MonoBehaviour
{
    private IMovable mover; // Referencia a la interfaz IMovable para el movimiento
    private ActualizadorVelocidad actualizadorVelocidad;// Instancia de la clase ActualizadorVelocidad para actualizar la velocidad

    public float initialSpeed = 2f; // Velocidad inicial del objeto
    public float acceleration = 5f;// Aceleracion del objeto
    private float currentSpeed; // Velocidad actual del objeto


    private void Start()
    {
        mover = new Movimiento();// Instanciar un objeto de tipo Movimiento que implementa IMovable
        actualizadorVelocidad = new ActualizadorVelocidad();// Instanciar un objeto de tipo ActualizadorVelocidad
        currentSpeed = initialSpeed;// Establecer la velocidad actual igual a la velocidad inicial
    }

    private void Update()
    {
        currentSpeed = actualizadorVelocidad.ActualizaVelocidad(currentSpeed, acceleration);// Actualizar la velocidad con el objeto ActualizadorVelocidad
        mover.Move(transform, currentSpeed);// Mover el objeto con el metodo Move de la interfaz IMovable
    }
}

