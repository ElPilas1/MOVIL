using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlappyJump : MonoBehaviour
{
    public float addforce;
    private Rigidbody rb;
    private Camera _cam;
    // Start is called before the first frame update
    void Start()
    {
        _cam = Camera.main;
        rb = GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    void Update()
    {
#if UNITY_EDITOR||UNITY_STANDALONE
        if(Input.GetMouseButtonDown(0))|| Input.GetMouseButtonDown(KeyCode.Space));
        {

        }
    }
}
