using UnityEngine;

public class MovimientoGenerador : MonoBehaviour
{
    private float speedX = 4f;

    void Update()
    {
        MoveGenerator();
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