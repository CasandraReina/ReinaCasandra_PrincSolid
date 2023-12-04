using UnityEngine;

// Clase que utiliza un objeto que implementa la interfaz MovementController para controlar el movimiento.
public class MovimientoGenerador : MonoBehaviour
{
    private MovementController movementController;

    void Start()
    {
        // Se instancia un HorizontalMovementController con una velocidad inicial de 4f.
       movementController = new HorizontalMovementController(4f);
       // movementController = new HorizontalAccelerationController(3f, 1f);
    }

    void Update()
    {
        // Se llama al metodo Move del objeto movementController.
         movementController.Move(transform); 
      
    }
}
