using UnityEngine;
using UnityEngine.InputSystem;

public class ToggleObjectWithKeybind : MonoBehaviour
{
    [SerializeField] private GameObject _object;

    [SerializeField] private InputActionReference _inputActionRef;

    private void OnEnable()
    {
        if (_inputActionRef != null && _inputActionRef.action != null)
        {
            _inputActionRef.action.performed += OnActionPerformed;
            _inputActionRef.action.Enable();
        }
    }

    private void OnDisable()
    {
        if (_inputActionRef != null && _inputActionRef.action != null)
        {
            _inputActionRef.action.performed -= OnActionPerformed;
            _inputActionRef.action.Disable();
        }
    }

    private void OnActionPerformed(InputAction.CallbackContext context)
    {
        _object.SetActive(!_object.activeSelf);
    }
}
