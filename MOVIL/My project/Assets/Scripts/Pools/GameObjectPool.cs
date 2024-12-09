using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;

public class GameObjectPool : MonoBehaviour
{
    private List<GameObject> _poolList = new List<GameObject>();
    [Tooltip("Initial pool Size")]
    public uint poolSize;//por si queremos expandir el pool
    [Tooltip("If the boolean is true,size increase")]
    public bool shouldExpand = false;
    [Tooltip("The object is going to pool")]
    public GameObject ObjectToPool;

    private void Start()
    {
        _poolList = new List<GameObject>();
        for (int i = 0; i < poolSize; i++)//el for es para instanciar poolSize objectos
        {
            AddGameObjectToPool();
        }
    }
    public GameObject GiveMeAInactiveGameObject()
    {
        foreach (GameObject obj in _poolList)//repasa la Lista //IMPORTANTE
        {
            if (!obj.activeSelf)//Si el objecto no esta Activo
            {
                return obj;//devuelve el objecto
            }
        }
        if (shouldExpand)//si queremos añadir la pool
        {
            AddGameObjectToPool();
        }
        
        return null;//si no lo encuentra el la lista devuelve nada
    }
    GameObject AddGameObjectToPool()
    {
        GameObject clone = Instantiate(ObjectToPool);//Instancia el objecto para pool
        clone.SetActive(false);//lo activas en falso para que no haga cosas raras
        _poolList.Add(clone);//añade a la lista
        return clone;//devuelve lo que acaba de añadir

    }
}
