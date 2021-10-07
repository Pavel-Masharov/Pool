using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Text _resultGameText;
    [SerializeField] private GameObject _restart;

    public bool isActiveGame;

    private CounterBall _countPlayer;
    private CounterBall _countEnemy;

    [SerializeField] private int _goodBall = 10;
    void Start()
    {
        isActiveGame = true;
        _countPlayer = GameObject.Find("Floor").GetComponent<CounterBall>();
        _countEnemy = GameObject.Find("FloorEnemy").GetComponent<CounterBall>();
    }

    void Update()
    {
        ResultGame();
    }

    private void ResultGame()
    {
        if(_countPlayer._count == _goodBall)
        {
            isActiveGame = false;
            _resultGameText.gameObject.SetActive(true);
            _resultGameText.text = "YOU WIN";
            _restart.SetActive(true);


        }
        else if( _countEnemy._count == _goodBall)
        {
            isActiveGame = false;
            _resultGameText.gameObject.SetActive(true);
            _resultGameText.text = "YOU LOSE";
            _restart.SetActive(true);

        }
    }
}
