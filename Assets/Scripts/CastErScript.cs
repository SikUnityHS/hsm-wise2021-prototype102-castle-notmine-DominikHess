using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CastErScript : MonoBehaviour
{

    //code for waypoints

    public GameObject[] waypoints;
    int current = 0;
    float rotSpeed;
    public float speed;
    float WPradius = 0.5f;


    public int attempt = 1;


    //code for waypoints and movement

    void Update()
    {
        if (Vector3.Distance(waypoints[current].transform.position, transform.position) < WPradius)
        {

            current++;
            if (current >= waypoints.Length)
            {
                current = 0;
            }
        }
        transform.position = Vector3.MoveTowards(transform.position, waypoints[current].transform.position, Time.deltaTime * speed);
    }

}
