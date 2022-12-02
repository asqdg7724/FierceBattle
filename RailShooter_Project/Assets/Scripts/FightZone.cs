using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FightZone : MonoBehaviour
{
    public GameObject Exit;
    public Transform nodeLocation;
    public float size;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Collider[] col = Physics.OverlapSphere(transform.position, size, 1 << 7);

        if (col.Length <= 0)
        {
            Debug.Log("적들 모두 처치");
            Instantiate(Exit, nodeLocation.position, nodeLocation.rotation);
            Destroy(gameObject);
        }
    }

    void OnDrawGizmos()
    {
        Gizmos.color = new Color(1, 1, 1, 0.3f);
        Gizmos.DrawSphere(transform.position, size);
    }
}
