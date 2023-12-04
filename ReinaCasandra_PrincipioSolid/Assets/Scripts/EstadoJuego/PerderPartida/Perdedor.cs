using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Implementación concreta de la lógica de perder
public class Perdedor : IPerdedor
{
    private ISceneManager escenaManager;

    public Perdedor(ISceneManager escenaManager)
    {
        this.escenaManager = escenaManager;
    }

    public void Perder()
    {
        if (escenaManager != null)
        {
            escenaManager.CargarEscena("Perdiste");
        }
    }
}
