using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    DiscreteMovement discretemovement;

    void Awake () {
        discretemovement = GetComponent<DiscreteMovement>();
    }

    void Update () {
        
        Vector3 vel = Vector3.zero;

        if(Input.GetKey(KeyCode.A)) {
            vel.x = -1;
        }
        else if(Input.GetKey(KeyCode.D)) {
            vel.x = 1;
        }
        else if(Input.GetKey(KeyCode.W)) {
            vel.y = 1;
        }
        else if(Input.GetKey(KeyCode.S)) {
            vel.y = -1;
        }

        discretemovement.MoveTransform(vel);
    }

}