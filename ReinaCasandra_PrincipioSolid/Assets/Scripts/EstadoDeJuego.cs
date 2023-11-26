using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EstadoDeJuego : MonoBehaviour
{
  public void ReturnGanaste(string Menu)
  {
    SceneManager.LoadScene(Menu);
  }

  public void ReturnPerdiste(string Nivel1)
  {
    SceneManager.LoadScene(Nivel1);
  }
}

