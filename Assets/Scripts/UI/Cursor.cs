using StarterAssets;
using UnityEngine;

public class Cursor : MonoBehaviour
{
    [SerializeField] private ObjectVisibilityWatcher _objectVisibilityWatcher;

    public bool cursorLocked = true;

    private void OnEnable()
    {
        if (_objectVisibilityWatcher != null)
        {
            _objectVisibilityWatcher.OnObjectVisibilityChanged.AddListener(SetCursorVisibility);
        }
    }

    private void OnDisable()
    {
        if (_objectVisibilityWatcher != null)
        {
            _objectVisibilityWatcher.OnObjectVisibilityChanged.RemoveListener(SetCursorVisibility);
        }
    }

    public void SetCursorVisibility(bool visible)
    {
        UnityEngine.Cursor.visible = visible;
        UnityEngine.Cursor.lockState = visible ? CursorLockMode.None : CursorLockMode.Locked;

        cursorLocked = !visible;
    }

    private void OnApplicationFocus(bool hasFocus)
    {
        SetCursorVisibility(!cursorLocked);
    }
}
