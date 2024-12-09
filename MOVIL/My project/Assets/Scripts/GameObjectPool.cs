using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectPool : MonoBehaviour
{
    private List<GameObject> poolList = new List<GameObject>();
    [Tooltip("Initial pool Size")]
    public uint poolSize;
    [Tooltip("If the boolean is true,size increase")]
    public bool shouldExpand = false;
    [Tooltip("The object is going to pool")]
    public GameObject ObjectToPool;

    private void Start()
    {
        poolList = new List<GameObject>();
    }
    void AddGameObjectToPool()
    {
        GameObject clone = Instantiate(ObjectToPool);
        clone.SetActive(false);

    }
}
