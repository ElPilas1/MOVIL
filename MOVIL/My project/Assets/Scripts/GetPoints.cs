using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetPoints : MonoBehaviour
{
    public AudioClip audioClips;
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<FlappyJump>())
        {
            GameManager.instance.SetPoints(GameManager.instance.GetPoints()+1);
            AudioManager.instance.PlayAudio(audioClips, "Point", false, 1.0f);   
        }
    }
}
