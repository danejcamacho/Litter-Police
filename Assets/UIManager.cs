using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private Text _scoreText;

    [SerializeField]
    private Text _hiscoreText;

    [SerializeField]
    public int _score;

    [SerializeField]
    static public int _hiscore = 0;

    // Start is called before the first frame update
    public void Start()
    {
        _score = 0;
        _scoreText.text = "Score: " + 0;
        _hiscoreText.text = "Hi-Score: " + 0;
        

    }

    public void AddScore(int _killPoint){
        _score += _killPoint;
        _scoreText.text = "Score: " + _score.ToString();
    }

    void Update(){
        if (_score > _hiscore){
            _hiscore = _score;
        }
        _hiscoreText.text = "Hi-Score: " + _hiscore.ToString();

    } 

}


