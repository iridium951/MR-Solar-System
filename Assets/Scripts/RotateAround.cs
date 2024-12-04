using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAround : MonoBehaviour
{
    [SerializeField]
    private Vector3 rotationAxis = Vector3.up;

    [SerializeField]
    private float baseRotationSpeed;
	
	[SerializeField]
    private float adjustedRotationSpeed;
	
	[SerializeField]
    public RotationSpeedManager rotationSpeedManager;

    void Start()
    {
        adjustedRotationSpeed = baseRotationSpeed;
    }

    // Update is called once per frame
    void Update()
    {
		float slowDownFactor = 0.3f; // need to slow speeds down due to fixedDeltaTime
        transform.Rotate(rotationAxis, adjustedRotationSpeed * Time.fixedDeltaTime * slowDownFactor, Space.Self);
    }

    public void SetAdjustedRotationSpeed(float multiplier)
    {
        adjustedRotationSpeed = baseRotationSpeed * multiplier;
		Debug.Log("Adjusted Rotation Speed for " + gameObject.name + ": " + adjustedRotationSpeed);
		Debug.Log("New Rotation Speed for " + gameObject.name + ": " + baseRotationSpeed);
    }
}

