using UnityEngine;
using UnityEngine.Events;

public class ObjectVisibilityWatcher : MonoBehaviour
{
    public UnityEvent<bool> OnObjectVisibilityChanged;

    private void OnEnable()
    {
        OnObjectVisibilityChanged?.Invoke(true);
    }

    private void OnDisable()
    {
        OnObjectVisibilityChanged?.Invoke(false);
    }
}
