using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Implementacion de la logica de la escena al ganar
public class EscenaGanador : IEscenaGanador
{
    private ISceneManager escenaManager;

    public EscenaGanador(ISceneManager escenaManager)
    {
        this.escenaManager = escenaManager;
    }

    public void EscenaGanar()
    {
        if (escenaManager != null)
        {
            escenaManager.CargarEscena("Ganaste");
        }
    }
}
