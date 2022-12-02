using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProjectile : MonoBehaviour
{
    Rigidbody rb;
    Transform playerTransform;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        playerTransform = GameObject.Find("Gun").transform;
        rb = gameObject.GetComponent<Rigidbody>();
        Destroy(this.gameObject, 5);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerTransform.position, speed * Time.deltaTime);
    }
}
