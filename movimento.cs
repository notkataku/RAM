using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class movimento : MonoBehaviour
{
    public float speed = 5f;
    private int scarpe = 0;

    void Update()
    {

        if(scarpe!= 0){
            speed = speed + 2f;
            scarpe=0;
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
{
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
    }
}