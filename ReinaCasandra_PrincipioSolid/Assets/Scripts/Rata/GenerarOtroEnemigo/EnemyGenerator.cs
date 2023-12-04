using UnityEngine;

// Clase abstracta que define un generador de enemigos
public abstract class EnemyGenerator : MonoBehaviour
{
    // Metodo abstracto que debe ser implementado por las subclases
    protected abstract GameObject[] GetEnemyObjects();

    private void Start()
    {
        // Invoca el metodo SpawnEnemy despues de un tiempo aleatorio entre 1 y 4 segundos
        Invoke("SpawnEnemy", Random.Range(1f, 4f)); 
    }

    // Metodo que spawnea un enemigo
    private void SpawnEnemy()
    { 
        GameObject[] enemyObjects = GetEnemyObjects();  // Obtiene los objetos de enemigos de la subclase

       if (enemyObjects.Length > 0)
        {
            // Elije un indice aleatorio para seleccionar un objeto de enemigo
            int randomIndex = Random.Range(0, enemyObjects.Length);

            // Instancia un nuevo objeto de enemigo en la posicion y rotacion del generador
            GameObject newObject = Instantiate(enemyObjects[randomIndex], transform.position, transform.rotation);
        }

        // Establece un tiempo aleatorio para el proximo spawn y lo programa
        float randomTime = Random.Range(1f, 4f);
        Invoke("SpawnEnemy", randomTime); 
    }
}
