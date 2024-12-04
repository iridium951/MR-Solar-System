using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RotationSpeedControlUI : MonoBehaviour
{
    [SerializeField]
    private RotationSpeedManager rotationSpeedManager;
	
	[SerializeField]
    private TextMeshProUGUI rotationSpeedText;

	void Start()
    {
        UpdateRotationSpeedText();
    }
	
    public void IncreaseRotationSpeed()
    {
        if (rotationSpeedManager != null)
        {
            rotationSpeedManager.AdjustRotationSpeedMultiplier(0.4f);
			UpdateRotationSpeedText();
        }
    }

    public void DecreaseRotationSpeed()
    {
        if (rotationSpeedManager != null)
        {
            rotationSpeedManager.AdjustRotationSpeedMultiplier(-0.4f);
			UpdateRotationSpeedText();
        }
    }
	
	private void UpdateRotationSpeedText()
    {
        if (rotationSpeedText != null && rotationSpeedManager != null)
        {
            rotationSpeedText.text = "Rotation: " + rotationSpeedManager.rotationSpeedMultiplier.ToString("F1");
        }
	}
	
}