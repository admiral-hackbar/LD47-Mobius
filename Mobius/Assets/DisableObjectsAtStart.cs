using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableObjectsAtStart : MonoBehaviour
{
    public List<GameObject> gameObjects = new List<GameObject>();

    void Start()
    {
        foreach (GameObject gameObjectToDisable in gameObjects)
        {
            gameObjectToDisable.SetActive(false);
        }
    }
}
