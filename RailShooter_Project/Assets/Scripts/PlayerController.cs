using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public GameObject[] hpCounts;
    public GameObject[] bulletCounts;
    public GameObject reloadText;
    public GameObject dmgImage;
    public bool isHurt;
    public PlayerSFX sfx;
    public int hp;
    public Firing fire;

    void Start()
    {
        fire = GetComponent<Firing>();
        isHurt = false;
    }

    // Update is called once per frame
    void Update()
    {
        Life();
        BulletCount();

        if (fire.bullet <= 0)
        {
            reloadText.SetActive(true);
        }

        else
        {
            reloadText.SetActive(false);
        }
    }

    void Life()
    {
        if (hp > 5)
        {
            hp = 5;
        }

        switch (hp)
        {
            case 5:
                hpCounts[0].gameObject.SetActive(true);
                hpCounts[1].gameObject.SetActive(true);
                hpCounts[2].gameObject.SetActive(true);
                hpCounts[3].gameObject.SetActive(true);
                hpCounts[4].gameObject.SetActive(true);
                break;

            case 4:
                hpCounts[0].gameObject.SetActive(true);
                hpCounts[1].gameObject.SetActive(true);
                hpCounts[2].gameObject.SetActive(true);
                hpCounts[3].gameObject.SetActive(true);
                hpCounts[4].gameObject.SetActive(false);
                break;

            case 3:
                hpCounts[0].gameObject.SetActive(true);
                hpCounts[1].gameObject.SetActive(true);
                hpCounts[2].gameObject.SetActive(true);
                hpCounts[3].gameObject.SetActive(false);
                hpCounts[4].gameObject.SetActive(false);
                break;

            case 2:
                hpCounts[0].gameObject.SetActive(true);
                hpCounts[1].gameObject.SetActive(true);
                hpCounts[2].gameObject.SetActive(false);
                hpCounts[3].gameObject.SetActive(false);
                hpCounts[4].gameObject.SetActive(false);
                break;

            case 1:
                hpCounts[0].gameObject.SetActive(true);
                hpCounts[1].gameObject.SetActive(false);
                hpCounts[2].gameObject.SetActive(false);
                hpCounts[3].gameObject.SetActive(false);
                hpCounts[4].gameObject.SetActive(false);
                break;

            case 0:
                hpCounts[0].gameObject.SetActive(false);
                hpCounts[1].gameObject.SetActive(false);
                hpCounts[2].gameObject.SetActive(false);
                hpCounts[3].gameObject.SetActive(false);
                hpCounts[4].gameObject.SetActive(false);
                break;
        }
    }

    void BulletCount()
    {
        //int bulletCount = fire.bullet;
        switch (fire.bullet)
        {
            case 10:
                bulletCounts[0].gameObject.SetActive(true);
                bulletCounts[1].gameObject.SetActive(true);
                bulletCounts[2].gameObject.SetActive(true);
                bulletCounts[3].gameObject.SetActive(true);
                bulletCounts[4].gameObject.SetActive(true);
                bulletCounts[5].gameObject.SetActive(true);
                bulletCounts[6].gameObject.SetActive(true);
                bulletCounts[7].gameObject.SetActive(true);
                bulletCounts[8].gameObject.SetActive(true);
                bulletCounts[9].gameObject.SetActive(true);
                break;

            case 9:
                bulletCounts[0].gameObject.SetActive(true);
                bulletCounts[1].gameObject.SetActive(true);
                bulletCounts[2].gameObject.SetActive(true);
                bulletCounts[3].gameObject.SetActive(true);
                bulletCounts[4].gameObject.SetActive(true);
                bulletCounts[5].gameObject.SetActive(true);
                bulletCounts[6].gameObject.SetActive(true);
                bulletCounts[7].gameObject.SetActive(true);
                bulletCounts[8].gameObject.SetActive(true);
                bulletCounts[9].gameObject.SetActive(false);
                break;

            case 8:
                bulletCounts[0].gameObject.SetActive(true);
                bulletCounts[1].gameObject.SetActive(true);
                bulletCounts[2].gameObject.SetActive(true);
                bulletCounts[3].gameObject.SetActive(true);
                bulletCounts[4].gameObject.SetActive(true);
                bulletCounts[5].gameObject.SetActive(true);
                bulletCounts[6].gameObject.SetActive(true);
                bulletCounts[7].gameObject.SetActive(true);
                bulletCounts[8].gameObject.SetActive(false);
                bulletCounts[9].gameObject.SetActive(false);
                break;

            case 7:
                bulletCounts[0].gameObject.SetActive(true);
                bulletCounts[1].gameObject.SetActive(true);
                bulletCounts[2].gameObject.SetActive(true);
                bulletCounts[3].gameObject.SetActive(true);
                bulletCounts[4].gameObject.SetActive(true);
                bulletCounts[5].gameObject.SetActive(true);
                bulletCounts[6].gameObject.SetActive(true);
                bulletCounts[7].gameObject.SetActive(false);
                bulletCounts[8].gameObject.SetActive(false);
                bulletCounts[9].gameObject.SetActive(false);
                break;

            case 6:
                bulletCounts[0].gameObject.SetActive(true);
                bulletCounts[1].gameObject.SetActive(true);
                bulletCounts[2].gameObject.SetActive(true);
                bulletCounts[3].gameObject.SetActive(true);
                bulletCounts[4].gameObject.SetActive(true);
                bulletCounts[5].gameObject.SetActive(true);
                bulletCounts[6].gameObject.SetActive(false);
                bulletCounts[7].gameObject.SetActive(false);
                bulletCounts[8].gameObject.SetActive(false);
                bulletCounts[9].gameObject.SetActive(false);
                break;

            case 5:
                bulletCounts[0].gameObject.SetActive(true);
                bulletCounts[1].gameObject.SetActive(true);
                bulletCounts[2].gameObject.SetActive(true);
                bulletCounts[3].gameObject.SetActive(true);
                bulletCounts[4].gameObject.SetActive(true);
                bulletCounts[5].gameObject.SetActive(false);
                bulletCounts[6].gameObject.SetActive(false);
                bulletCounts[7].gameObject.SetActive(false);
                bulletCounts[8].gameObject.SetActive(false);
                bulletCounts[9].gameObject.SetActive(false);
                break;

            case 4:
                bulletCounts[0].gameObject.SetActive(true);
                bulletCounts[1].gameObject.SetActive(true);
                bulletCounts[2].gameObject.SetActive(true);
                bulletCounts[3].gameObject.SetActive(true);
                bulletCounts[4].gameObject.SetActive(false);
                bulletCounts[5].gameObject.SetActive(false);
                bulletCounts[6].gameObject.SetActive(false);
                bulletCounts[7].gameObject.SetActive(false);
                bulletCounts[8].gameObject.SetActive(false);
                bulletCounts[9].gameObject.SetActive(false);
                break;

            case 3:
                bulletCounts[0].gameObject.SetActive(true);
                bulletCounts[1].gameObject.SetActive(true);
                bulletCounts[2].gameObject.SetActive(true);
                bulletCounts[3].gameObject.SetActive(false);
                bulletCounts[4].gameObject.SetActive(false);
                bulletCounts[5].gameObject.SetActive(false);
                bulletCounts[6].gameObject.SetActive(false);
                bulletCounts[7].gameObject.SetActive(false);
                bulletCounts[8].gameObject.SetActive(false);
                bulletCounts[9].gameObject.SetActive(false);
                break;

            case 2:
                bulletCounts[0].gameObject.SetActive(true);
                bulletCounts[1].gameObject.SetActive(true);
                bulletCounts[2].gameObject.SetActive(false);
                bulletCounts[3].gameObject.SetActive(false);
                bulletCounts[4].gameObject.SetActive(false);
                bulletCounts[5].gameObject.SetActive(false);
                bulletCounts[6].gameObject.SetActive(false);
                bulletCounts[7].gameObject.SetActive(false);
                bulletCounts[8].gameObject.SetActive(false);
                bulletCounts[9].gameObject.SetActive(false);
                break;

            case 1:
                bulletCounts[0].gameObject.SetActive(true);
                bulletCounts[1].gameObject.SetActive(false);
                bulletCounts[2].gameObject.SetActive(false);
                bulletCounts[3].gameObject.SetActive(false);
                bulletCounts[4].gameObject.SetActive(false);
                bulletCounts[5].gameObject.SetActive(false);
                bulletCounts[6].gameObject.SetActive(false);
                bulletCounts[7].gameObject.SetActive(false);
                bulletCounts[8].gameObject.SetActive(false);
                bulletCounts[9].gameObject.SetActive(false);
                break;

            case 0:
                bulletCounts[0].gameObject.SetActive(false);
                bulletCounts[1].gameObject.SetActive(false);
                bulletCounts[2].gameObject.SetActive(false);
                bulletCounts[3].gameObject.SetActive(false);
                bulletCounts[4].gameObject.SetActive(false);
                bulletCounts[5].gameObject.SetActive(false);
                bulletCounts[6].gameObject.SetActive(false);
                bulletCounts[7].gameObject.SetActive(false);
                bulletCounts[8].gameObject.SetActive(false);
                bulletCounts[9].gameObject.SetActive(false);
                break;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Projectile")
        {
            TakeDamage(1);
            Destroy(other.gameObject);
        }

        else if (other.gameObject.tag == "Enemy")
        {
            TakeDamage(1);
        }

        else if (other.gameObject.tag == "Clear")
        {
            GameManager.instance.GameClear();
        }
    }

    public void TakeDamage(int damage)
    {
        if (!isHurt)
        {
            isHurt = true;
            hp -= damage;
            sfx.SoundPlay(3);
            StartCoroutine(DamageScreen());
        }
    }

    IEnumerator DamageScreen()
    {
        dmgImage.SetActive(true);

        yield return new WaitForSeconds(0.5f);

        dmgImage.SetActive(false);

        isHurt = false;
    }
}
