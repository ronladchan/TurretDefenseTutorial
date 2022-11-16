using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 10f;
    private Transform target;
    private int waypointsIndex = 0;


    // Start is called before the first frame update
    void Start()
    {
        target = Waypoints.points[0];
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dir = target.position - transform.position;
        transform.Translate (dir.normalized * speed * Time.deltaTime, Space.World);

        if(Vector3.Distance(transform.position, target.position) < .2f){
            GetNextWaypoint();
        }

    }

    void GetNextWaypoint(){
        if (waypointsIndex >= Waypoints.points.Length - 1){
            Destroy(gameObject);
            Debug.Log("You Lose");
            return;
        }

        waypointsIndex++;
        target = Waypoints.points[waypointsIndex];
    }
}
