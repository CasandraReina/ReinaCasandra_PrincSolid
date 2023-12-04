using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Esta clase hereda de MovementController,va a implementar la interfaz Move.
public class HorizontalMovementController : MovementController
{
    private float speed;

    // Constructor que recibe la velocidad inicial.
    public HorizontalMovementController(float speed)
    {
        this.speed = speed;
    }

    // Metodo Move de la interfaz MovementController.
    public void Move(Transform transform)
    {
        
        if (transform.position.x < -12.65f || transform.position.x > 10.5f)
        {
            speed *= -1;
        }

        // Mover el objeto horizontalmente multiplicando la velocidad por Time.deltaTime.
        transform.Translate(speed * Time.deltaTime, 0, 0);
    }
}