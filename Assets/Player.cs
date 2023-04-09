using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [SerializeField] AudioSource _audioSource;
    [SerializeField] float moveSpeed = 1f;
    [SerializeField] public UIManager _uIManager;
    bool hasTrash = false;
    // Start is called before the first frame update
    void Start()
    {
        _audioSource = GetComponent<AudioSource>();
        if(_audioSource == null){
            Debug.LogError("The Audio is null");
        }
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Trash"){
            if(hasTrash == false){
                Destroy(other.gameObject);
                hasTrash = true;
                _audioSource.Play();
            }
        }
        if (other.tag == "Bin"){
            if(hasTrash == true){
                //TODO add to score
                _uIManager.AddScore(1);
                hasTrash = false;
                _audioSource.Play();
            }
        }
        if (other.tag == "Enemy"){
            _uIManager.Start();
        }
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
