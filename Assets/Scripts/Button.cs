using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    [SerializeField] float _intervalCreateBall;

    private SpawnBall _spawnBall;

    [SerializeField] private GameObject _ButtonAll;



    private void Start()
    {
        _ButtonAll.SetActive(true);

        _spawnBall = GameObject.Find("SpawnBall").GetComponent<SpawnBall>();
    }

   
    public void ComplexityGame()
    {
        _ButtonAll.SetActive(false);

        _spawnBall.StartGame(_intervalCreateBall);
    }

    public void Restart()
    {
        SceneManager.LoadScene("MyGame");
    }
}
