using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Clase BigRat que hereda de EnemyGenerator
public class BigRata : EnemyGenerator 
{ 
    // Lista de objetos de tipo bigRat (enemigo)
    public GameObject[] bigRat;

    // Metodo abstracto GetEnemyObjects de EnemyGenerator
    protected override GameObject[] GetEnemyObjects()
    {
        return bigRat; // Retorna la lista de bigRat
    } 
}
