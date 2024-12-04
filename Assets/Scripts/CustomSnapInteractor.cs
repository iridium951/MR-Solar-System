using UnityEngine;
using Oculus.Interaction;

public class CustomSnapInteractor : SnapInteractor
{
    public event System.Action InteractableSelectedEvent;
    public event System.Action InteractableUnselectedEvent;

    protected override void InteractableSelected(SnapInteractable interactable)
    {
        base.InteractableSelected(interactable); // Call base method
        Debug.Log("Interactable selected"); // Debug log for testing
        InteractableSelectedEvent?.Invoke(); // Trigger the event when selected
    }

    protected override void InteractableUnselected(SnapInteractable interactable)
    {
        base.InteractableUnselected(interactable); // Call base method
        Debug.Log("Interactable unselected"); // Debug log for testing
        InteractableUnselectedEvent?.Invoke(); // Trigger the event when unselected
    }
}
