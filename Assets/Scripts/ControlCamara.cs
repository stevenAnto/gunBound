using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject player;
   private Vector3 offset = new Vector3(0.0f,5.0f,-10.23f);
    // Start is called before the first frame update
    void Start()
    {
        transform.position = player.transform.position + offset;
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
        
    }
}
