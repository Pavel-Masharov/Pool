using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed;
    private float limitMove = 14.0f;

   

    void FixedUpdate()
    {
      
            MovePlayer(_speed);
    }

    private void MovePlayer(float speed)
    {
        if (transform.position.x < -limitMove)
        {
            transform.position = new Vector3(-limitMove, transform.position.y, transform.position.z);
        }

        if (transform.position.x > limitMove)
        {
            transform.position = new Vector3(limitMove, transform.position.y, transform.position.z);
        }

        float inputHorizontal = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * inputHorizontal * _speed * Time.deltaTime);
    }
    
}
