/**using UnityEngine;
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
}**/

using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ContadorPuntos : MonoBehaviour
{
    private int contador;
    public TextMeshProUGUI contadorRatas;

    void Start()
    {
        contador = 0;
    }

    public void IncrementarContador()
    {
        contador++;
        contadorRatas.text = contador.ToString();
    }

    public bool VerificarGanador()
    {
        if (contador >= 30)
        {
            return true;
        }
        return false;
    }

    public void CargarEscenaGanador()
    {
        SceneManager.LoadScene(2);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject);
        IncrementarContador();

        if (VerificarGanador())
        {
            CargarEscenaGanador();
        }
    }
}