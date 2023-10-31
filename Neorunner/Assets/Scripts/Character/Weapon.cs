using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firepoint;
    public GameObject bullet;

    void Update (){
        if (Input.GetKeyDown(KeyCode.E)){

            Shoot();
        }
    }

    void Shoot (){

        Instantiate(bullet, firepoint.position, firepoint.rotation);
    }
}
