using UnityEngine;
using TMPro;

public class TiempoDeJuego : MonoBehaviour
{
    public TextMeshProUGUI textoTiempo;
    private float tiempoTranscurrido = 0f;

    void Update()
    {
        tiempoTranscurrido += Time.deltaTime;
        int minutos = (int)tiempoTranscurrido / 60;
        int segundos = (int)tiempoTranscurrido % 60;
        string textoFormateado = string.Format("{0:00}:{1:00}", minutos, segundos);
        textoTiempo.text = "" + textoFormateado;
    }
}