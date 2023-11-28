using UnityEngine;

public class MovimientoRata : MonoBehaviour
{
    public float velocidadInicial =  2f;
    public float aumentoVelocidad =  5f;
    private float velocidad;

    void Start()
    {
        velocidad = velocidadInicial;
    }
    
    void Update()
    {
        MoveRat();
        
        // Aumentar la velocidad con el tiempo transcurrido
        velocidad += aumentoVelocidad * Time.deltaTime;
    }

    private void MoveRat()
    {
        // Calculamos la nueva posición del objeto
        Vector3 nuevaPosicion = transform.position + new Vector3(0f, 0f, velocidad * Time.deltaTime);
        
        // Movemos el objeto a la nueva posición
        transform.position = nuevaPosicion;
    }

}