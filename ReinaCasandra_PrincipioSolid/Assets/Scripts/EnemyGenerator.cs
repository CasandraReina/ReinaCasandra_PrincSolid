using UnityEngine;

public abstract class EnemyGenerator : MonoBehaviour
 {
     protected abstract GameObject[] GetEnemyObjects();

private void Start()
 {
     Invoke("SpawnEnemy", Random.Range(1f, 4f)); 
 }

private void SpawnEnemy()
{ 
    GameObject[] enemyObjects = GetEnemyObjects();
    int randomIndex = Random.Range(0, enemyObjects.Length);

    GameObject newObject = Instantiate(enemyObjects[randomIndex], transform.position, transform.rotation);
    float randomTime = Random.Range(1f, 4f); Invoke("SpawnEnemy", randomTime); 
}

 }