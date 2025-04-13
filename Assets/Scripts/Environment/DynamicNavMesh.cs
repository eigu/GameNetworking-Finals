using Unity.AI.Navigation;
using UnityEngine;

public class DynamicNavMesh : MonoBehaviour
{
    [SerializeField] private NavMeshSurface _meshSurface;
    [SerializeField] private float _updateFrequency = 0.1f;

    private float _timer = 0f;

    private void Start()
    {
        if (_meshSurface == null)
        {
            _meshSurface = GetComponent<NavMeshSurface>();
        }

        _meshSurface.BuildNavMesh();
    }

    private void Update()
    {
        _timer += Time.deltaTime;

        if (_timer >= _updateFrequency)
        {
            _meshSurface.UpdateNavMesh(_meshSurface.navMeshData);
            _timer = 0f;
        }
    }
}