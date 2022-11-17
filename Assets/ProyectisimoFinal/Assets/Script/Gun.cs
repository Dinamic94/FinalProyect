using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public float range = 100f;
    public Camera fpsCam;
    
    

    void Start()
    {
        
    }

   
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Disparar();
        }
    }
    void Disparar()
    {
        RaycastHit hit; 
        if(Physics.Raycast(fpsCam.transform.position,fpsCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);
            if(hit.transform.CompareTag("Enemy"))
            {
                Debug.Log("Has disparado a un enemy");
            }
            if(hit.transform.CompareTag("Enemy2"))
            {
                Debug.Log("Le has disparado al Enemy2");
            }
        }       
    }
}
