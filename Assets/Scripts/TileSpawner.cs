using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileSpawner : MonoBehaviour
{
    [Header("Tile Spawning")]
    [SerializeField] private GameObject _tilePrefab;
    [SerializeField] private int _initialSpawnCount;
    [SerializeField] private int _tileWidth;
    [SerializeField] [Tooltip("Time between tile spawns")] private int _tileSpawnRate;

    private readonly LinkedList<GameObject> _tiles = new LinkedList<GameObject>();

    private int _nextTilePosition;
    private float _spawnProgress;

    private void Awake()
    {
        _spawnProgress = _tileSpawnRate;
        _nextTilePosition = -_tileWidth;
        for (int i = 0; i < _initialSpawnCount; i++)
        {
            GenerateTile();
        }
    }

    private void GenerateTile()
    {
        Vector3 position = new Vector3(0, 0, _nextTilePosition);
        GameObject tile = Instantiate( _tilePrefab, position, Quaternion.identity, transform);
        _tiles.AddLast(tile);
        _nextTilePosition += _tileWidth;
    }

    private void Update()
    {
        _spawnProgress -= Time.deltaTime;
        if (_spawnProgress <= 0)
        {
            GenerateTile();
            Destroy(_tiles.First.Value);
            _tiles.RemoveFirst();
            _spawnProgress = _tileSpawnRate;
        }
    }
}
