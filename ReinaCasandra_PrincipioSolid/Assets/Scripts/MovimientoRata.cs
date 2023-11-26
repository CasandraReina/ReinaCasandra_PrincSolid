
using UnityEngine;

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
}