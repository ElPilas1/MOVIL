using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Vector3 _dir;
    public Rigidbody rb;
    public float maxtime;
    private float currentTime;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        currentTime += Time.deltaTime;
        if (currentTime > maxtime)
        {
            currentTime = 0;
            gameObject.SetActive(false);
        }
    }
    // Update is called once per frame
    private void FixeUpdate()
    {
        rb.velocity = speed * _dir;
    }
    public void SetDirection(Vector3 value)
    {
        _dir = value;
    }
}
