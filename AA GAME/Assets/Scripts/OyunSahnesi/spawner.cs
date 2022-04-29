using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
   public GameObject kucukcubuk;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            KucukCubukSpawn();
        }
        void KucukCubukSpawn(){
            Instantiate(kucukcubuk,transform.position,transform.rotation);
        }
        
    }
}
