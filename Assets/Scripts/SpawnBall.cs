using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBall : MonoBehaviour
{
    [SerializeField] private GameObject _ball;
    [SerializeField] private float _xRange;
    [SerializeField] private float _yPos;
    [SerializeField] private float _zPos;

    private GameManager _gameManager;

    private void Start()
    {
        _gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }


    public void StartGame(float intervalCreateBall)
    {
        
        InvokeRepeating("CreateBall",2f, intervalCreateBall);
    }

   private void CreateBall()
   {
        if (_gameManager.isActiveGame)
            Instantiate(_ball, CretePosBall(_xRange, _yPos, _zPos), _ball.transform.rotation);
   }

    private Vector3 CretePosBall(float posX, float yPos, float zPos)
    {
        posX = Random.Range(-_xRange, _xRange);
        return new Vector3(posX, yPos, zPos);
    }
   
}
