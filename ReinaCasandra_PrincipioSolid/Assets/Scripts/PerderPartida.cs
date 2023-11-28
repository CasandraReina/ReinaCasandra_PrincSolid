using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PerderPartida : MonoBehaviour
{
  private void OnCollisionEnter(Collision collision)
    {
        // Comprobar si la colisión es con el tipo de objeto deseado
        if (collision.gameObject.CompareTag("Puerta"))
        {
            SceneManager.LoadScene(3);
            Destroy(gameObject);
            Debug.Log("Perdio");
        }
    }
}
