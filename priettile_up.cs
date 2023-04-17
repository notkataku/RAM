using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class priettile_up : MonoBehaviour
{
     public float speed = 10.0f;
      public float yPosition = 5f;
       public GameObject prefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
   void Update()
{
    transform.position += Vector3.up * speed * Time.deltaTime;
    if (transform.position.y >= yPosition)
        {
            Destroy(prefab);
        }
}
void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "cattivo")
        {
            Destroy(prefab);
        }
    }
}
