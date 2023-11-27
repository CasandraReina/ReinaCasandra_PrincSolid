using UnityEngine;
using TMPro;

public class ColisionJaula : MonoBehaviour
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
    }
}