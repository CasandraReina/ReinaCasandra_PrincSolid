using UnityEngine;
using UnityEngine.SceneManagement;

// Implementacion de la carga de escenas
public class EscenaManager : ISceneManager
{
    public void CargarEscena(string nombreEscena)
    {
        SceneManager.LoadScene(nombreEscena);
    }
}
