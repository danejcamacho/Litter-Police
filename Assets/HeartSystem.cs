using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartSystem : MonoBehaviour
{
    public GameObject[] hearts;
    public int life;

    
    // Update is called once per frame
    void Update()
    {
        if (life < 1) {
            Destroy(hearts[0].gameObject);
            Invoke("EndGame", .7f );
            
        }
        else if (life < 2){
            Destroy(hearts[1].gameObject);
        }
    }

    public void TakeDamage(int i) {
        life -= i;
    }

    void EndGame() {
        FindObjectOfType<GameManager>().EndGame();
    }
}
