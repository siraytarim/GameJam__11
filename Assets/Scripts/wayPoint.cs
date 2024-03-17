using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class wayPoint : MonoBehaviour
{

    public Transform[] waypoints; // Waypoint'lerin listesi
    public float speed = 2.0f; // Nesnenin h�z�
    public int currentWaypointIndex = 0;

//    public GameObject sonk�p;
    Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    bool esit = false;
    void Update()
    {
      
        float distanceToWaypoint = Vector3.Distance(transform.position, waypoints[currentWaypointIndex].position);

       
        if (distanceToWaypoint < 0.1f)
        {
            
            currentWaypointIndex++;

            
            if (currentWaypointIndex >= waypoints.Length)
            {
                Destroy(gameObject);
            }
        }

        
        transform.position = Vector3.MoveTowards(transform.position, waypoints[currentWaypointIndex].position, speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "karanl�k")
        {
            anim.SetTrigger("Play");
        }
    }
}
