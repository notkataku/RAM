using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
     public float speed = 5f;
    
     public GameObject prefab;
    public GameObject prefab1;
    public GameObject prefab2;
    public GameObject prefab3;
    public GameObject player;
    public int danno=2;
     public int vita = 5;
     public bool scarpe = false;
     public bool damegUp = false;
     public bool helt = false;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     if(scarpe && speed<15){
            speed = speed + 4f;
            scarpe=false;
        }
         if(helt && vita<10){
            vita= vita+2;
            helt=false;
        }
         if(damegUp && danno<4){
            danno= danno + 1;
            damegUp=false;
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
         if (Input.GetKeyDown(KeyCode.LeftArrow))
    { 
        Instantiate(prefab, transform.position, transform.rotation);
           
    }
    if (Input.GetKeyDown(KeyCode.RightArrow))
    {
        Instantiate(prefab1, transform.position, transform.rotation);
    }
     if (Input.GetKeyDown(KeyCode.UpArrow))
    {
        Instantiate(prefab2, transform.position, transform.rotation);
    }
     if (Input.GetKeyDown(KeyCode.DownArrow))
    {
        Instantiate(prefab3, transform.position, transform.rotation);
    }
    
       
    


    }  
     void OnCollisionEnter2D(Collision2D collision)
    {
       
        if (collision.gameObject.tag == "cattivo")
        { 
            vita = vita - 1;
            if(vita==0){
            Destroy(player);
        }
        }
        if (collision.gameObject.tag == "scarpe")
        { 
           scarpe=true;
        }
         if (collision.gameObject.tag == "helt")
        { 
           helt=true;
        }
        if (collision.gameObject.tag == "DamegUp")
        {
            damegUp = true;
        }

    } 
 }

