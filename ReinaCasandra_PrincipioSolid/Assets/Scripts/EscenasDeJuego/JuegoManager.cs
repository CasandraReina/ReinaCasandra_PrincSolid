using UnityEngine;

// Clase para gestionar el estado del juego
public class JuegoManager
{
    public void Salir()  // Metodo para salir del juego
    {
        Application.Quit(); // Cierra la aplicacion
        Debug.Log("Se cierra el juego");
    }
}
