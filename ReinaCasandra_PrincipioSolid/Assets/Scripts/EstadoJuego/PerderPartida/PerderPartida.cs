using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// Implementación concreta de la lógica de perder partida
public class PerderPartida : MonoBehaviour
{
    private IPerdedor perdedor;

    private void Start()
    {
        perdedor = new Perdedor(new EscenaManager());
    }

    public void OnCollisionEnter(Collision collision)
    {
        // Comprobar si la colisión es con el tipo de objeto deseado
        if (collision.gameObject.CompareTag("Puerta"))
        {
            perdedor.Perder();
        }
    }
}
