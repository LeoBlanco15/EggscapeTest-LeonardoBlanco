using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackCollider : MonoBehaviour
{
    bool damaged;
    private void OnEnable()
    {
        damaged = false;
        StartCoroutine(UnableAttack());
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag != "Player" || other.gameObject == this.gameObject || damaged)
            return;
        PlayerStats aux = other.GetComponent<PlayerStats>();
        aux.ReciveDamage(5);
        damaged = true;
    }


    private IEnumerator UnableAttack()
    {
        yield return new WaitForSeconds(0.5f);

        this.gameObject.SetActive(false);
    }
}
