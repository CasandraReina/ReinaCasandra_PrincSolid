using UnityEngine;

public class Generador : MonoBehaviour
{
    //public GameObject[] bigRat;
    private float speedX = 4f;
    //public GenerateRat generateRat;

    private void Start()
    {
    }

    void Update()
    {
        MoveGenerator();
        //generateRat.SpawnRat();
    }

     private void MoveGenerator()
    {
        if(transform.position.x < -12.65f || transform.position.x > 10.5f )
        {
             speedX *= -1;
        }
        transform.Translate(speedX*Time.deltaTime,0,0);
    }
}