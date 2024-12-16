using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetPipePool : MonoBehaviour
{
    public GameObjectPool pipePool;
    public float maxTime;
    public float currentTime;
    public float maxHeight, minHeigth;

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
            obj.transform.localPosition = transform.position;
            obj.GetComponent<Pipe>().SetDirection(Vector3.left);
            obj.transform.position=new Vector3(transform.position.x, Random.Range(minHeigth,maxHeight),transform.position.z);

        }
       
        
    }
}



