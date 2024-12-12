using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipePool : MonoBehaviour
{
    public GameObjectPool pipePool;
    public float maxTime;
    public float currentTime;

    // Start is called before the first frame update
    void Start()
    {
        PipeSpawner();
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
        if(currentTime >= maxTime) 
        {

            PipeSpawner();
            currentTime = 0;
        
        }
    }



    private void PipeSpawner()
    {
        GameObject obj= pipePool.GiveMeAInactiveGameObject();
        if (obj)
        {
            obj.SetActive(true);//activar el objecto
            obj.transform.position = transform.position;
            obj.GetComponent<Pipe>().SetDirection(Vector3.left);

        }
       
        
    }
}



