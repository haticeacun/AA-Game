using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KucukCember : MonoBehaviour
{
    Rigidbody2D rb;
    public float hiz;
    public bool stop;
    public GameObject yonetici;
    void Start()
    {
        yonetici=GameObject.FindGameObjectWithTag("Yonetici");
        rb=GetComponent<Rigidbody2D>();
    }

    void Update()
    { 
        if(stop==false){
            rb.MovePosition(rb.position+Vector2.up*hiz*Time.deltaTime);
        }

    }
    private void OnTriggerEnter2D(Collider2D col) {
        if(col.gameObject.tag=="DonenBuyukCember"){
            transform.SetParent(col.transform);
            stop=true;
        }
        if(col.gameObject.tag=="KucukCember"){
            yonetici.GetComponent<OyununSonu>().OyunuBitir();
        }
    }   
 
}
