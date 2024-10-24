using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sonar : MonoBehaviour
{
    public Material sonarMat;  // Le matériau utilisé dans le shader du sonar
    public SubmarineNavigator submarineNavigator;  // Le script qui gère la position du sous-marin

    void Update()
    {
        if (submarineNavigator != null && sonarMat != null)
        {
            // Récupère la position actuelle et précédente du sous-marin
            Vector4 submarinePreviousPosition = submarineNavigator.submarinePreviousPosition;
            Vector4 submarineCurrentPosition = submarineNavigator.submarineCurrentPosition;

            // Mettre à jour les propriétés du shader avec les positions
            sonarMat.SetVector("_Position", submarinePreviousPosition);  // Met à jour la position précédente dans le shader
            sonarMat.SetVector("_NextPosition", submarineCurrentPosition);  // Met à jour la position actuelle dans le shader
        }
    }
}
