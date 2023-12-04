using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EstadoDeJuego : MonoBehaviour
{
    private EscenaManager escenaManager; // Instancia de la clase EscenaManager para gestionar las escenas del juego
    private JuegoManager juegoManager;   // Instancia de la clase JuegoManager para gestionar el estado del juego

    private void Start()
    {
        escenaManager = new EscenaManager();  // Inicializacion de la instancia de EscenaManager
        juegoManager = new JuegoManager(); // Inicializacion de la instancia de JuegoManager
    }

    // Metodo para iniciar el juego cargando la escena del nivel 1
    public void Play(string Nivel1)
    {
        escenaManager.CargarEscena(Nivel1);
    }

    // Metodo para regresar al menu principal despues de ganar
    public void ReturnGanaste(string Menu)
    {
        escenaManager.CargarEscena(Menu);
    }

    // Metodo para regresar al nivel 1 despues de perder
    public void ReturnPerdiste(string Nivel1)
    {
        escenaManager.CargarEscena(Nivel1);
    }

    // Metodo para salir del juego
    public void Salir()
    {
        juegoManager.Salir();
    }
}


