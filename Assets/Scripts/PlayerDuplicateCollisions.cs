using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class PlayerDuplicateCollisions : MonoBehaviour
{
    private Tilemap groundTileMap;
    private Tilemap obstaclesTileMap;

    public void Start()
    {
        groundTileMap = GetComponentInParent<PlayerController>().groundTileMap;
        obstaclesTileMap = GetComponentInParent<PlayerController>().obstaclesTileMap;
    }

    public void Update()
    {
        Vector3Int gridPosition = groundTileMap.WorldToCell(transform.position);
        if (!groundTileMap.HasTile(gridPosition) || obstaclesTileMap && obstaclesTileMap.HasTile(gridPosition))
        {
            Destroy(gameObject);
        }
    }
}
