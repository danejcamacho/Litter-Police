using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow_camera : MonoBehaviour
{
    [SerializeField] GameObject thingToFollow;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = thingToFollow.transform.position + new Vector3(0,0,-10);

    }
}