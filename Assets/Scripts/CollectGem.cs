using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectGem : MonoBehaviour
{
    [SerializeField] GameObject sceneLoader;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Gem")
        {
            Destroy(collision.gameObject);
            sceneLoader.GetComponent<SceneLoader>().LoadNextScene();
        }
    }
}
