using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CollisionController : MonoBehaviour
{
    public Contador contadorPuntos;
    private PuntuacionActualizacion puntuacionActualizacion;
    private ColisionGestor colisionGestor;

    void Start()
    {
        contadorPuntos = GetComponent<Contador>(); // Obtiene la instancia del componente Contador asociado al mismo GameObject.
        puntuacionActualizacion = new PuntuacionActualizacion(); // Inicializa una nueva instancia de PuntuacionActualizacion.

        colisionGestor = new ColisionGestor(); // Inicializa una nueva instancia de ColisionGestor.
    }


    private void OnCollisionEnter(Collision collision)
    {
        string collisionTag = collision.gameObject.tag;
        // Obtiene la etiqueta del GameObject con el que se ha producido la colision.

        puntuacionActualizacion.ActualizarPuntuacion(collisionTag, contadorPuntos);
        // Llama al metodo ActualizarPuntuacion de la instancia de PuntuacionActualizacion.

        colisionGestor.GestionarColision(collision);
        // Llama al metodo GestionarColision de la instancia de ColisionGestor.
    }
}
