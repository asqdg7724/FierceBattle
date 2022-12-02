using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPoint : MonoBehaviour
{
    public WayPoint[] nextWayPoint = new WayPoint[1];
    public bool lookAtWayPoint = false;
    internal bool reachedWayPoint = false;
    public EnemySpawn[] enemies;
    public bool waitForEnemies = true;
    public float freeLook = 0;
    public float removeEnemiesDelay = 3;
    public float moveDelay = 0;
    public float moveSpeed = 10;
    public float moveAcceleration = 0;
    public float turnSpeed = 100;

    internal int index;
    internal float gizmoTime = 0;

    void Awake()
    {
        GetComponent<Camera>().enabled = false;
    }

    void OnValidate()
    {
        //if (nextWaypoint.Length > 1) nextWaypoint = new ORSWaypoint[0];

        if (waitForEnemies == true) removeEnemiesDelay = 0;
    }
}
