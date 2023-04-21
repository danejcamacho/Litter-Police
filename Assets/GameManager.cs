using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public UIManager _uIManager;
    public HeartSystem _heartSystem;
    public void EndGame() {
        _heartSystem.life = 2;
        _uIManager.Start();
        SceneManager.LoadScene(0);

    }
}
