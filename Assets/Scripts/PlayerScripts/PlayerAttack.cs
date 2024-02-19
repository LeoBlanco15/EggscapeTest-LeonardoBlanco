using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FishNet.Connection;
using FishNet.Object;


public class PlayerAttack : NetworkBehaviour
{
    public GameObject attackCollider;
    public Animator animator;
    public int damage;
    private bool attacked;
    // Start is called before the first frame update
    void Start()
    {
        attackCollider.SetActive(false);
        attacked = false;
    }

    public override void OnStartClient()
    {
        base.OnStartClient();
        if (!base.IsOwner)
            this.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            AttackServerRpc();
        }
    }

    [ServerRpc]
    private void AttackServerRpc()
    {
        AttackObserverRpc();
    }

    /// <summary>
    /// Activates the attack collider and triggers the Attack animation
    /// </summary>
    [ObserversRpc]
    private void AttackObserverRpc()
    {
        if (!attacked)
        {
            animator.SetTrigger("Attack");
            attacked = true;
            attackCollider.SetActive(true);
            StartCoroutine(AttackCooldown());
        }
    }

    /// <summary>
    /// cooldown so the attack is not spammed
    /// </summary>
    /// <returns></returns>
    private IEnumerator AttackCooldown()
    {
        yield return new WaitForSeconds(0.5f);

        animator.ResetTrigger("Attack");
        attacked = false;
    }
}
