using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy1 : MonoBehaviour
{
    public GameObject nemico;
    public playerController otherScript;
    public int vita = 4;
    public int danno = 1;
    public Transform oggettoDaInseguire;
    public float velocita;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       // playerController playerController = FindObjectOfType<playerController>();

        transform.position = Vector3.MoveTowards(transform.position, oggettoDaInseguire.position, velocita * Time.deltaTime);
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
       
        if (collision.gameObject.tag == "bullet")
        { 
            int danno = otherScript.danno;
            vita = vita - danno;
            if(vita==0 && vita < 0){
            Destroy(nemico);
        }
        }
    }

}
