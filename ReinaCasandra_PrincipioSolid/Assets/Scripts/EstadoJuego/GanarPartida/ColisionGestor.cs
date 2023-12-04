using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisionGestor
{
    public void GestionarColision(Collision collision)
    {
        // Logica para gestionar colisiones
        Object.Destroy(collision.gameObject);
    }
}

