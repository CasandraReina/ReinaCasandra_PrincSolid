using UnityEngine;
using UnityEngine.SceneManagement;

public class MovimientoRata : MonoBehaviour
{
    public float velocidad = 2f;
    
    void Update()
    {
        // Calculamos la nueva posición del objeto
        Vector3 nuevaPosicion = transform.position + new Vector3(0f, 0f, velocidad * Time.deltaTime);
        
        // Movemos el objeto a la nueva posición
        transform.position = nuevaPosicion;
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Comprobar si la colisión es con el tipo de objeto deseado
        if (collision.gameObject.CompareTag("Puerta"))
        {
            SceneManager.LoadScene(3);
            Debug.Log("Perdio");
        }
    }
}