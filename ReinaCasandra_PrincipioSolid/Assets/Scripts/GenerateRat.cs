using UnityEngine;

public class GenerateRat : MonoBehaviour
{
    public GameObject[] rat;

    private void Start()
    {
        Invoke("SpawnRat", Random.Range(1f, 4f));
    }

    public void SpawnRat()
    {
        int randomIndex = Random.Range(0, rat.Length);
        GameObject newObject = Instantiate(rat[randomIndex], transform.position, transform.rotation);

        float randomTime = Random.Range(1f, 4f);
        Invoke("SpawnRat", randomTime);
    }
}
