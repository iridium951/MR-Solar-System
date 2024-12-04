using UnityEngine;

public class PlanetInfoDisplay : MonoBehaviour
{
    public GameObject infoCanvas;

    void Start()
    {
        infoCanvas.SetActive(false); // Ensure the canvas is hidden at the start
    }

    public void ShowInfo()
    {
        infoCanvas.SetActive(true); // Show canvas when planet is grabbed
    }

    public void HideInfo()
    {
        infoCanvas.SetActive(false); // Hide canvas when planet is released
    }
}
