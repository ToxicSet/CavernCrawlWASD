using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour, IWeapon
{
    public List<BaseStat>  Stats { get; set; }
    private Animator animator;

    void Start() 
    { 

    }    
    public void PerformAttack()
    {
        animator.SetTrigger("Attack");
        Debug.Log(this.name + "Sword attack!");
    }

    public void PerformSpecialAttack()
    {
        Debug.Log(this.name + "Sword attack!");
    }

    void OnTriggerEnter(Collider collider)
    {
        Debug.Log("Hit: " + collider.name);
        if (collider.tag == "Enemy")
        {
            Debug.Log("Hit Enemy");

        }
    }


}
