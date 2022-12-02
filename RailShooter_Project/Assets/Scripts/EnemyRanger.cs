using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRanger : Enemy
{
    public Transform nodeTransform;
    Transform playerTransform;
    public GameObject firePos;
    public GameObject projectile;
    public bool isAttack;
    public float attackDelay;
    public bool isAlive;
    private bool hasAniComp = false;

    // Start is called before the first frame update
    void Start()
    {
        playerTransform = GameObject.Find("Gun").transform;
        isAlive = true;

        if (null != GetComponent<Animation>())
        {
            hasAniComp = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (isAlive == false)
            return;

        RaycastHit hit;

        Vector3 targetVec = (nodeTransform.position - transform.position);
        Debug.DrawRay(transform.position, targetVec, Color.red, 10f);

        if (Physics.Raycast(transform.position, targetVec, out hit, 100f, 1 << 3))
        {
            Debug.Log("플레이어 인식");
            transform.LookAt(playerTransform);
            Attack();
        }
    }

    bool CheckAniClip(string clipname)
    {
        if (this.GetComponent<Animation>().GetClip(clipname) == null)
            return false;
        else if (this.GetComponent<Animation>().GetClip(clipname) != null)
            return true;

        return false;
    }

    void Attack()
    {
        if (isAlive)
        {
            if (!isAttack)
            {
                if (CheckAniClip("attack_short_001") == false)
                    return;

                GetComponent<Animation>().CrossFade("attack_short_001", 0.0f);
                GetComponent<Animation>().CrossFadeQueued("idle_combat");

                StartCoroutine(Attacking());

                isAttack = true;

                Invoke(nameof(AttackDelay), attackDelay);
            }
            
        }
    }

    void AttackDelay()
    {
        isAttack = false;
    }

    public override void TakeDamage(int damage)
    {
        Hp -= damage;
        Debug.Log("적 데미지");
    }

    public override void TakeWeakDamage(int damage)
    {
        if (isAlive == true)
        {
            Hp -= damage;

            if (CheckAniClip("damage_001") == false)
                return;

            GetComponent<Animation>().CrossFade("damage_001", 0.0f);
            GetComponent<Animation>().CrossFadeQueued("idle_combat");

            Debug.Log("적 크리티컬 데미지");
        }
    }

    public override void Die()
    {
        //StartCoroutine(DelayDie());

        isAlive = false;
        Destroy(gameObject);

        Debug.Log(this.name + " 사망");
    }

    void DiePlay()
    {
        if (hasAniComp == true)
        {
            if (CheckAniClip("dead") == false)
                return;

            GetComponent<Animation>().CrossFade("dead", 0.2f);
        }
    }

    IEnumerator Attacking()
    {
        yield return new WaitForSeconds(0.6f);

        Instantiate(projectile, firePos.transform.position, transform.rotation);
    }

    /*IEnumerator DelayDie()
    {
        DiePlay();

        yield return new WaitForSeconds(2.5f);

        Destroy(gameObject);
    }*/

    

    
}
