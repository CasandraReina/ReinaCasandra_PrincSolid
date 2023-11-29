using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuboGenerator : EnemyGenerator
{
      public GameObject[] cubo;

protected override GameObject[] GetEnemyObjects()
 {
     return cubo; 
 } 

}
