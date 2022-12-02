using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameManager gm;
    public int hp;

    public int Hp
    {
        get { return hp; }
        set
        {
            hp = value;

            if (hp <= 0)
            {
                Die();
            }
        }
    }

    public virtual void TakeDamage(int damage)
    {
        gm.score += 100;
        Hp -= damage;
        Debug.Log("�� ������");
    }

    public virtual void TakeWeakDamage(int damage)
    {
        gm.score += 300;
        Hp -= damage;
        Debug.Log("�� ũ��Ƽ�� ������");
    }

    public virtual void Die()
    {
        gm.score += 500;
        Destroy(gameObject);
        Debug.Log(this.name + " ���");
    }
}
