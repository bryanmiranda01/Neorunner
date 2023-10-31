using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour {
    public float speed = 5;
    public Transform point1;
    public Transform point2;
 
    IEnumerator Start()
    {
        Transform target = point1;
        while (true)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
            if (Vector2.Distance(transform.position, target.position) <= 0)
            {
                target = target == point1 ? point2 : point1;
                yield return new WaitForSeconds(0.5f);
            }
            yield return null;
        }
    }
}