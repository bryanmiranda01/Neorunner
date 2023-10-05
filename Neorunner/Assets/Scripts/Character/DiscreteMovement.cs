using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiscreteMovement : MonoBehaviour
{
    [SerializeField] float speed;
    public void MoveTransform(Vector3 vel) {
        transform.position += vel * speed * Time.deltaTime;

    }
}