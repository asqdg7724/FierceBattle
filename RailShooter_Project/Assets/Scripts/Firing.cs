using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Firing : MonoBehaviour
{
    public float fireRange;
    public int bullet;
    public int maxBullet;
    public GameObject fireEffect;
    public GameObject hitEffect;
    public GameObject weakEffect;
    public Text reloadText;
    public bool isEmpty;
    public PlayerSFX sfx;
    

    void Start()
    {
        isEmpty = false;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Shoot();
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            sfx.SoundPlay(2);
            bullet = maxBullet;
        }
    }

    public void Shoot()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        

        if (bullet > 0)
        {

            if (Physics.Raycast(ray, out hit, fireRange, 1 << 6))
            {
                Enemy enemy = hit.transform.GetComponent<Enemy>();

                Debug.Log(hit.transform.name);

                Debug.Log("약점 히트");

                GameObject weakImpact = Instantiate(weakEffect, hit.point, Quaternion.LookRotation(hit.normal));
                Destroy(weakImpact, 1f);

                bullet -= 1;

                if (enemy != null)
                {
                    enemy.TakeWeakDamage(3);
                }
            }

            else if (Physics.Raycast(ray, out hit, fireRange, 1 << 8))
            {
                GameObject heatImpact = Instantiate(hitEffect, hit.point, Quaternion.LookRotation(hit.normal));
                Destroy(heatImpact, 1f);

                Debug.Log("발사체 파괴");
                Destroy(hit.transform.gameObject);
            }

            else if (Physics.Raycast(ray, out hit, fireRange))
            {
                Debug.Log(hit.transform.name);

                GameObject heatImpact = Instantiate(hitEffect, hit.point, Quaternion.LookRotation(hit.normal));
                Destroy(heatImpact, 1f);

                bullet -= 1;

                Enemy enemy = hit.transform.GetComponent<Enemy>();
                if (enemy != null)
                {
                    enemy.TakeDamage(1);
                }
            }

            else
            {
                Vector3 mPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                GameObject fireImpact = Instantiate(fireEffect, mPosition, Quaternion.identity);
                mPosition.z = 0f;
                Destroy(fireImpact, 1f);

                bullet -= 1;
            }
        }

        BulletCheck();
    }

    void BulletCheck()
    {
        if (bullet == 0)
        {
            isEmpty = true;
            sfx.SoundPlay(1);
        }

        else if (bullet > 0)
        {
            isEmpty = false;
            sfx.SoundPlay(0);
        }
    }
}
