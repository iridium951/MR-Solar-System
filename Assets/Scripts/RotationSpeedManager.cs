using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationSpeedManager : MonoBehaviour
{
    [SerializeField]
    public float rotationSpeedMultiplier;

    [SerializeField]
    private RotateAround[] rotatingObjects;
	
	void Start()
    {
        rotatingObjects = FindObjectsOfType<RotateAround>();
        UpdateAllRotationSpeeds();
    }

    public void AdjustRotationSpeedMultiplier(float adjustment)
    {
        rotationSpeedMultiplier += adjustment;
        rotationSpeedMultiplier = Mathf.Clamp(rotationSpeedMultiplier, 0.1f, 10f);
        UpdateAllRotationSpeeds();
    }

    private void UpdateAllRotationSpeeds()
    {
        foreach (RotateAround obj in rotatingObjects)
        {
            obj.SetAdjustedRotationSpeed(rotationSpeedMultiplier);
			Debug.Log("Setting adjusted speed for " + obj.name + " with multiplier: " + rotationSpeedMultiplier);
        }
    }
}