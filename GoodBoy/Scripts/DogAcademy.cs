using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MLAgents;

public class DogAcademy : Academy
{
    private DogArea[] areas;

    /// <summary>
    /// Reset the academy
    /// </summary>
    public override void AcademyReset()
    {
        if (areas == null)
        {
            areas = GameObject.FindObjectsOfType<DogArea>();
        }

        foreach (DogArea area in areas)
        {

            area.numTruffles = (int)resetParameters["num_truffles"];
            area.numStumps = (int)resetParameters["num_stumps"];
            area.spawnRange = resetParameters["spawn_range"];

            area.ResetArea();
        }
    }
}
