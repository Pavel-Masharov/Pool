using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CounterBall : MonoBehaviour
{
    [SerializeField] private Text CounterText;
    [SerializeField] private string _text; 
    public int _count;

    void Start()
    {
        _count = 0;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Ball"))
        {
            _count++;
            CounterText.text = _text + " " +  _count;
        }
    }

}
