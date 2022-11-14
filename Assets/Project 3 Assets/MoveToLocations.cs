using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToLocations : MonoBehaviour
{
    public GameObject[] wayPoints; //Make sure you set rotation of these points too as they determine which way object faces
    int current = 0;
    float rotSpeed = 15;
    public float speed;
    float radius = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 movementDirection = new Vector3(horizontalInput, 0, verticalInput);
        if(Vector3.Distance(wayPoints[current].transform.position, transform.position) < radius) { //if within 1 of waypoint
            current+=1;
            if (current >= wayPoints.Length){
                current = 0;
            }
        }
        transform.position = Vector3.MoveTowards(transform.position, wayPoints[current].transform.position, Time.deltaTime * speed);
        transform.rotation = wayPoints[current].transform.rotation;
    }
}
