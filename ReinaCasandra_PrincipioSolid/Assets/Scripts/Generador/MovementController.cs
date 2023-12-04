using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Interfaz que define el metodo Move, cualquier clase que la implemente tendra un metodo para mover.
public interface MovementController
{
    void Move(Transform transform);
}