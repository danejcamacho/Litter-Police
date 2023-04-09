using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    /*public Rigidbody2D rb;
    public float speed = 1;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        int _range = Random.Range(0,10);
        if (_range == 0){
            Vector2 Movement = new Vector2 (Random.Range(-1, 1), Random.Range(-1, 1));
            rb.AddForce (Movement);
            print (Movement);
        }
    }*/
    public Rigidbody2D rb;
    public float timeToChangeDirection = 0f;
    public void Start () {
         ChangeDirection();
         rb = GetComponent<Rigidbody2D>();
     }
     
     // Update is called once per frame
     public void Update () {
         timeToChangeDirection -= Time.deltaTime;
 
         if (timeToChangeDirection <= 0) {
             ChangeDirection();
         }
 
         GetComponent<Rigidbody2D>().velocity = transform.up * 2;
         Vector2 Movement = new Vector2 (Random.Range(-1, 1), Random.Range(-1, 1));
            rb.AddForce (Movement);
            print (Movement);
     }
 
 
 
     private void ChangeDirection() {
         float angle = Random.Range(0f, 360f);
         Quaternion quat = Quaternion.AngleAxis(angle, Vector3.forward);
         Vector3 newUp = quat * Vector3.up;
         newUp.z = 0;
         newUp.Normalize();
         transform.up = newUp;
         timeToChangeDirection = 1.5f;
     }
}
