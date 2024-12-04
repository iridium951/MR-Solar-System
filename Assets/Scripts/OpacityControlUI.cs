using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class OpacityControlUI : MonoBehaviour
{
    public OVRPassthroughLayer passthroughLayer;
	
	[SerializeField]
    public TextMeshProUGUI opacityText; 

    private float opacityStep = 0.05f;

    void Start()
    {
        GameObject ovrCameraRig = GameObject.Find("OVRCameraRig");
        if (ovrCameraRig == null)
        {
            Debug.LogError("Scene does not contain an OVRCameraRig");
            return;
        }

        passthroughLayer = ovrCameraRig.GetComponent<OVRPassthroughLayer>();
        if (passthroughLayer == null)
        {
            Debug.LogError("OVRCameraRig does not contain an OVRPassthroughLayer component");
        }
		
		{
        UpdateOpacityText();
		}
	
    }

    public void IncreaseOpacity()
    {
        if (passthroughLayer != null)
        {
            passthroughLayer.textureOpacity = Mathf.Clamp(passthroughLayer.textureOpacity + opacityStep, 0f, 1f);
            UpdateOpacityText();
        }
    }

    public void DecreaseOpacity()
    {
        if (passthroughLayer != null)
        {
            passthroughLayer.textureOpacity = Mathf.Clamp(passthroughLayer.textureOpacity - opacityStep, 0f, 1f);
            UpdateOpacityText();
        }
    }

    private void UpdateOpacityText()
    {
        if (opacityText != null && passthroughLayer != null)
        {
            opacityText.text = "Opacity: " + passthroughLayer.textureOpacity.ToString("F2"); // Display opacity with 2 decimals
        }
    }
}
