using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ContadorPuntos : MonoBehaviour
{
    private int contador;
    public TextMeshProUGUI contadorRatas;

    void start()
    {
        contador = 0;
    }

    private void OnCollisionEnter(Collision collision)
    {
            contador++;
            contadorRatas.text = contador.ToString();
            Destroy(collision.gameObject);

            if (contador >= 30)
           {
            SceneManager.LoadScene(2);
           }
    }
}