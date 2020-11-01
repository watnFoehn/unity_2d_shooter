using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{

    [SerializeField]
    private float _speed = 8.0f;
    
    void Update()
    {
     CalculateMovement();

     if(transform.position.y > 7f){
         Destroy(this.gameObject);
     }

    }
     void CalculateMovement(){
        transform.Translate(Vector3.up *  _speed * Time.deltaTime);
     }
}
