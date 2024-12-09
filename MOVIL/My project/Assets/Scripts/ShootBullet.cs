using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBullet : MonoBehaviour
{
    public GameObjectPool bulletPool;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Firel"))
        {
            GameObject obj = bulletPool.GiveMeAInactiveGameObject();
            if (obj != null) //si hay informacion en el objecto
            {
                obj.SetActive(true);//activar el objecto
                obj.transform.position = transform.position;
                obj.GetComponent<Bullet>().SetDirection(transform.forward); 
            }
        }
    }
}
