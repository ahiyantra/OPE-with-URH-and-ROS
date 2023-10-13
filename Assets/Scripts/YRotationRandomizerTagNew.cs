using UnityEngine;
using UnityEngine.Perception.Randomization.Randomizers;

public class YRotationRandomizerTagNew : RandomizerTag
{
    private Vector3 originalRotation;

    private void Start()
    {
        originalRotation = transform.eulerAngles;
    }

    public void SetYRotation(float yRotation)
    {
        transform.eulerAngles = new Vector3(originalRotation.x, yRotation, originalRotation.z);
    }
}
