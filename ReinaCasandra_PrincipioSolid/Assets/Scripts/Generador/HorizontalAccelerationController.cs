using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalAccelerationController : MovementController
{
    private float initialSpeed;
    private float acceleration;

    // Constructor que recibe la velocidad inicial y la aceleracion
    public HorizontalAccelerationController(float initialSpeed, float acceleration)
    {
        this.initialSpeed = initialSpeed;
        this.acceleration = acceleration;
    }

    // Mtodo Move de la interfaz MovementController
    public void Move(Transform transform)
    {
        float speed = initialSpeed + acceleration * Time.time;
        
        if (transform.position.x < -12.65f || transform.position.x > 10.5f)
        {
            speed *= -1;
        }

        // Mover el objeto horizontalmente multiplicando la velocidad por Time.deltaTime.
        transform.Translate(speed * Time.deltaTime, 0, 0);
    }
}
