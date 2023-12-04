using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Implementacion del movimiento hacia adelante
public class Movimiento : IMovable
{
    // Metodo de la interfaz IMovable para mover el objeto hacia adelante
    public void Move(Transform transform, float speed)
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
