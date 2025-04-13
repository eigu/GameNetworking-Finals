using UnityEngine;

public class PlatformMovement : MonoBehaviour
{
    [SerializeField] private Vector3 _offsetPosition;
    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _distanceThreshold;

    private Vector3 m_startPosition;
    private bool m_movingToNextPosition = true;

    private void Start()
    {
        m_startPosition = transform.position;
    }

    private void Update()
    {
        Vector3 targetPosition = m_movingToNextPosition ? m_startPosition + _offsetPosition : m_startPosition;

        transform.position = Vector3.Lerp(transform.position, targetPosition, _moveSpeed * Time.deltaTime);

        if (Vector3.Distance(transform.position, targetPosition) < _distanceThreshold)
        {
            m_movingToNextPosition = !m_movingToNextPosition;
        }
    }
}