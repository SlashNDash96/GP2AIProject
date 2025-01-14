using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowWaypoint2 : MonoBehaviour
{
    Transform goal;
    float speed = 5.0f;
    float accuracy = 1.0f;
    float rotSPeed = 2.0f;

    public GameObject wpManager;
    GameObject[] wps;
    GameObject currentNode;
    int currentWP = 0;
    Graph g;

    // Start is called before the first frame update
    void Start()
    {
        wps = wpManager.GetComponent<WaypointManager>().waypoints;
        g = wpManager.GetComponent<WaypointManager>().graph;
        currentNode = wps[0];
    }

    public void GoTOHeli()
    {
        g.AStar(currentNode, wps[0]);
        currentWP = 0;
    }

    public void GoToRuin()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
