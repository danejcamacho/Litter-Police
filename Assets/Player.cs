using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float moveSpeed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveAmountHoriz = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        transform.Translate(moveAmountHoriz, 0, 0);
        float moveAmountVert = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Translate(0, moveAmountVert, 0);
        
    }
}
