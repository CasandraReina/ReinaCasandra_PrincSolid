using UnityEngine;

public class Generador : MonoBehaviour
{
    public GameObject[] objectPrefabs;

    private void Start()
    {
        InvokeRepeating("GenerateObject", 4f, 4f);
    }

    private void GenerateObject()
    {
        int randomIndex = Random.Range(0, objectPrefabs.Length);
        GameObject newObject = Instantiate(objectPrefabs[randomIndex], transform.position, transform.rotation);
        Destroy(newObject, 10f);
    }
}
