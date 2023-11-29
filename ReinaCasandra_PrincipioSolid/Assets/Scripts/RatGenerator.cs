using UnityEngine;

public class RatGenerator : EnemyGenerator 
{ 
    public GameObject[] rat;

protected override GameObject[] GetEnemyObjects()
 {
     return rat; 
 } 

}
