using UnityEngine;

public class MovimientoPersonaje : MonoBehaviour
{
    public float movementSpeed = 5f; // Velocidad de movimiento del personaje

    void Update()
    {
      MoveCharacter();
    }

    private void MoveCharacter()
    {
          // Obtener las entradas del teclado para mover el personaje
        float moveX = Input.GetAxis("Horizontal");
 
        // Calcular la dirección del movimiento
        Vector3 moveDirection = new Vector3(moveX, 0f, 0f).normalized;

        // Calcular la velocidad de movimiento del personaje
        Vector3 moveVelocity = moveDirection * movementSpeed;

        // Mover el personaje
        transform.Translate(moveVelocity * Time.deltaTime);
    }
}