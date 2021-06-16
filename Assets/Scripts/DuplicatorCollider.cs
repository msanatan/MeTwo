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
        Debug.Log("You're in the red zone");
        CreateDuplicate();
    }

    private void CreateDuplicate() {
        var duplicatePlayer = Instantiate(duplicatePrefab, cloneSpawnPosition.position, cloneSpawnPosition.rotation);
        duplicatePlayer.transform.parent = player.transform;
    }
}
