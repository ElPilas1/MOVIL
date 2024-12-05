using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateParticles : MonoBehaviour
{
    public GameObject particlesprefab;
    private Camera _cam;

    private void Start()
    {
        _cam = Camera.main;//para llamar a la cámara
    }
    // Update is called once per frame
    void Update()
    {
#if UNITY_EDITOR || UNITY_STANDALONE
        //PC
        if (Input.GetMouseButtonDown(0))
        {
            InstanceParticle(Input.mousePosition);
        }
        //Android
#elif UNITY_ANDROID//PARA COMPILAR EN ANDROID
        foreach (Touch touch in Input.touches)//por cada toque qye haya habido en la pantalla
        {
            if (touch.phase == TouchPhase.Began)//dectar el toque en la pantalla por primera vez
            {
                InstanceParticle(touch.position);
            }
        }
#endif//para acabar el if
    }
        void InstanceParticle(Vector3 screenCoords)
        {
            screenCoords.z = 10;
            Vector3 gameCoords = _cam.ScreenToWorldPoint(screenCoords);
            Instantiate(particlesprefab, gameCoords, Quaternion.identity);//para instanciar el prefab
        }
    }
}

    

