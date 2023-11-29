using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EstadoDeJuego : MonoBehaviour
{
    private EscenaManager escenaManager;
    private JuegoManager juegoManager;

    private void Start()
    {
        escenaManager = new EscenaManager();
        juegoManager = new JuegoManager();
    }

    public void Play(string Nivel1)
    {
        escenaManager.CargarEscena(Nivel1);
    }

    public void ReturnGanaste(string Menu)
    {
        escenaManager.CargarEscena(Menu);
    }

    public void ReturnPerdiste(string Nivel1)
    {
        escenaManager.CargarEscena(Nivel1);
    }

    public void Salir()
    {
        juegoManager.Salir();
    }
}


