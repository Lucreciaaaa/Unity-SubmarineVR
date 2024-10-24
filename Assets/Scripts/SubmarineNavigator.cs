using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubmarineNavigator : MonoBehaviour
{
    public Vector4 submarinePreviousPosition;  // Position précédente du sous-marin
    public Vector4 submarineCurrentPosition;   // Position actuelle du sous-marin

    public float updateFrequency = 1f;  // Fréquence de mise à jour des positions (si nécessaire)

    void Start()
    {
        
        submarineCurrentPosition = new Vector4(0, 0, 0, 0);
        submarinePreviousPosition = submarineCurrentPosition;

        

    void UpdatePositions()
    {
        
        submarinePreviousPosition = submarineCurrentPosition;
        submarineCurrentPosition = new Vector4(Random.Range(-10f, 10f), 0, Random.Range(-10f, 10f), 0);
    }
}

}
