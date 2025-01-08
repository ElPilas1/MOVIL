using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetPoints : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<FlappyJump>())
        {
            GameManager.instance.SetPoints(GameManager.instance.GetPoints()+1);
        }
    }
}
