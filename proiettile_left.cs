using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class proiettile_left : MonoBehaviour
{
   public float speed = 10.0f;
      public float xPosition = -8f;
       public GameObject prefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
   void Update()
{
    transform.position += Vector3.left * speed * Time.deltaTime;
   if (transform.position.x <= xPosition)
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
