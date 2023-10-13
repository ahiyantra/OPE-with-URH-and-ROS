using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.Perception.Randomization.Parameters;
using UnityEngine.Perception.Randomization.Randomizers;
using UnityEngine.Perception.Randomization.Samplers;


[Serializable]
[AddRandomizerMenu("Perception/Y Rotation Randomizer New")]
public class YRotationRandomizerNew : Randomizer
{
    public FloatParameter rotationRange = new FloatParameter { value = new UniformSampler(0f, 360f) }; // in range (0, 1)

    protected override void OnIterationStart()
    {
        IEnumerable<YRotationRandomizerTagNew> tags = tagManager.Query<YRotationRandomizerTagNew>();
        foreach (YRotationRandomizerTagNew tag in tags)
        {
            float yRotation = rotationRange.Sample();

            // sets rotation
            tag.SetYRotation(yRotation);
        }
    }
}
