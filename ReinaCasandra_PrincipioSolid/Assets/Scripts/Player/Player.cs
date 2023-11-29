using UnityEngine;

public class Player : MonoBehaviour
{
   public float movementSpeed = 5f; // Velocidad de movimiento del personaje

   public void MoveCharacter(float moveX)
    {
        // Calcular la dirección del movimiento
        Vector3 moveDirection = new Vector3(moveX, 0f, 0f).normalized;

        // Calcular la velocidad de movimiento del personaje
        Vector3 moveVelocity = moveDirection * movementSpeed;

        // Mover el personaje
        transform.Translate(moveVelocity * Time.deltaTime);
    }
}