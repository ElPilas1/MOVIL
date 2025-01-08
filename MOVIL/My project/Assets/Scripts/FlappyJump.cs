using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FlappyJump : MonoBehaviour
{
    public float addforce, rotationSpeed;
    private Rigidbody rb;
    private Camera _cam;
    // Start is called before the first frame update
    // Start is called before the first frame update
    void Start()
    {
        _cam = Camera.main;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
#if UNITY_EDITOR || UNITY_STANDALONE

        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
        {
            ApplyJump();//Aplica el saltos


        }

#elif UNITY_ANDROID

        foreach (Touch touch in Input.touches)
        {
            if(touch.phase == TouchPhase.Began)
            {
                ApplyJump();
            }
        }
#endif
    }
    private void FixedUpdate()
    {
        transform.rotation = Quaternion.Euler(0, 180, rb.velocity.y * -rotationSpeed);
    }


    void ApplyJump()
    {
        rb.velocity = new Vector3(0, 0, 0);//solo vectores 0 de velocidad
        rb.AddForce(Vector3.up * addforce);//lo multiplica para arriba con la fuerza que queiras

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pipe"))//si el gameobject es Pipe 
        {
            Debug.Log("Te chocaste");
            SceneManager.LoadScene("Inicio");
            Destroy(gameObject);
        }

    }
}