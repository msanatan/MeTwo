using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuplicatorCollider : MonoBehaviour
{
    [SerializeField] Transform cloneSpawnPosition;
    [SerializeField] GameObject duplicatePrefab;
    [SerializeField] GameObject player;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            CreateDuplicate();
        }
    }

    private void CreateDuplicate() {
        var duplicatePlayer = Instantiate(duplicatePrefab, cloneSpawnPosition.position, cloneSpawnPosition.rotation);
        duplicatePlayer.transform.tag = "PlayerDuplicate";
        var dpSpriteRenderer = duplicatePlayer.GetComponent<SpriteRenderer>();
        dpSpriteRenderer.sortingLayerName = "Player";
        dpSpriteRenderer.sortingOrder = 0;
        duplicatePlayer.transform.parent = player.transform;
        // Copy scene loader - needed for transitions to work if the gem is with the duplicate
        var playerController = player.GetComponent<CollectGem>();
        var duplicateController = duplicatePlayer.GetComponent<CollectGem>();
        duplicateController.sceneLoader = playerController.sceneLoader;
    }
}
