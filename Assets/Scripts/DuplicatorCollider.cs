using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuplicatorCollider : MonoBehaviour
{
    [SerializeField] Transform cloneSpawnPosition;
    [SerializeField] GameObject duplicatePrefab;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("You're in the red zone");
        CreateDuplicate();
    }

    private void CreateDuplicate() {
        Instantiate(duplicatePrefab, cloneSpawnPosition.position, cloneSpawnPosition.rotation);
    }
}
