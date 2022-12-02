using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWarrior : Enemy
{
    public Transform nodeTransform;
    Transform playerTransform;
    public float attackRange;
    Animator animator;
    public bool playerInAttackRange;
    public bool isAlive;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        playerTransform = GameObject.Find("Gun").transform;
        isAlive = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (isAlive == false)
            return;

        RaycastHit hit;

        Vector3 targetVec = (nodeTransform.position - transform.position);
        Debug.DrawRay(transform.position, targetVec, Color.red, 15f);

        playerInAttackRange = Physics.CheckSphere(transform.position, attackRange, 1 << 3);

        if (Physics.Raycast(transform.position, targetVec, out hit, 15f, 1 << 3))
        {
            Move();
        }
    }

    public override void TakeWeakDamage(int damage)
    {
        if (isAlive)
        {
            animator.SetTrigger("Damage");

            Hp -= damage;
            Debug.Log("적 크리티컬 데미지");
        }
    }

    public override void Die()
    {
        if (isAlive)
        {
            StartCoroutine(DelayDie());

            Debug.Log(this.name + " 사망");
        }
    }

    void Move()
    {
        if (isAlive)
        {
            Debug.Log("적의 플레이어 인식");
            animator.SetFloat("Speed", 0.1f);
            Vector3 targetPos = playerTransform.position;

            if (Vector3.Distance(transform.position, targetPos) > 8f)
                transform.position = Vector3.MoveTowards(transform.position, targetPos, 0.05f);

            else
                StartCoroutine(DelayAttack());
        }
    }

    IEnumerator DelayDie()
    {
        animator.SetTrigger("Death");

        isAlive = false;

        yield return new WaitForSeconds(2.5f);

        Destroy(gameObject);
    }

    IEnumerator DelayAttack()
    {
        animator.SetFloat("Speed", 0f);

        animator.SetTrigger("Attack");

        yield return new WaitForSeconds(2f);
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, attackRange);
    }
}
