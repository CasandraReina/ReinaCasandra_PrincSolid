using UnityEngine;

public class GenerateRat : MonoBehaviour
{
    public GameObject[] rat;

    private void Start()
    {
        Invoke("SpawnRat", Random.Range(1f, 4f)); //Invoca al metodo "SpawnRat" despues de un tiempo aleatorio entre 1 y 4 segundos. Esto hace que se generen ratas periódicamente en el juego.
    }

    private void SpawnRat() //Define un metodo privado llamado "SpawnRat" que genera una rata en una posicion aleatoria de la escena.
    {
        int randomIndex = Random.Range(0, rat.Length);//Genera un numero entero aleatorio entre 0 y la longitud del arreglo "rat". Este numero se utilizara para seleccionar un objeto de rata del arreglo.
        GameObject newObject = Instantiate(rat[randomIndex], transform.position, transform.rotation); //Crea un nuevo objeto instanciando uno de los objetos de rata del arreglo "rat" en la posicion y rotación actual del objeto que tiene este script.

        float randomTime = Random.Range(1f, 4f);//Genera un numero decimal aleatorio entre 1 y 4. Este numero se utilizara para determinar el tiempo en segundos entre la generación de ratas.
        Invoke("SpawnRat", randomTime);//Invoca al metodo "SpawnRat" despues de un tiempo determinado por la variable "randomTime". Esto crea un ciclo de generación periódica de ratas en el juego.

    }
}
