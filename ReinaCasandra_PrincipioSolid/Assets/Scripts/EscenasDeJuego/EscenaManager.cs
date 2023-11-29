using UnityEngine;
using UnityEngine.SceneManagement;

public class EscenaManager
{
    public void CargarEscena(string nombreEscena)
    {
        SceneManager.LoadScene(nombreEscena);
    }
}
