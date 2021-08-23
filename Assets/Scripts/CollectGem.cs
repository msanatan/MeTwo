using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectGem : MonoBehaviour
{
    public SceneLoader sceneLoader;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Gem")
        {
            Destroy(collision.gameObject);
            sceneLoader.LoadNextScene();
        }
    }
}
