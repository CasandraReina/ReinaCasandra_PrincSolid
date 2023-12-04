using UnityEngine;

// Clase RatGenerator que hereda de EnemyGenerator
public class RatGenerator : EnemyGenerator 
{ 
    // Lista de objetos de tipo rat (enemigo)
    public GameObject[] rat;

    // Metodo abstracto GetEnemyObjects de EnemyGenerator
    protected override GameObject[] GetEnemyObjects()
    {
        return rat; // Retorna la lista de rat
    } 
}

