using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Interfaz para manejar el movimiento del objeto
public interface IMovable
{
    // Metodo para mover el objeto con una velocidad dada
    void Move(Transform transform, float speed);
}
