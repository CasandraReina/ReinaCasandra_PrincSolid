using UnityEngine;


public class PlayerController : MonoBehaviour
{
    // Declaración de una variable privada para almacenar una instancia de la clase Player.
    private Player player;

    private void Start()
    {
        // Asigna a la variable 'player' la referencia al componente Player asociado a este GameObject.
        player = GetComponent<Player>();
    }

    void Update()
    {
        // Llama al método CaptureInput() en cada actualización.
        CaptureInput();
    }

    // Método privado para capturar la entrada del usuario.
    private void CaptureInput()
    {
        // Obtiene el valor de entrada horizontal (teclas A y D o flechas izquierda y derecha).
        float moveX = Input.GetAxis("Horizontal");

        // Llama al método MoveCharacter() de la instancia 'player', pasando el valor de entrada horizontal.
        player.MoveCharacter(moveX);
    }
}

