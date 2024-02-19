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
        //checks if the collision is a player other than self and then deals damage
        if (other.gameObject.tag != "Player" || other.gameObject == this.gameObject || damaged)
            return;
        PlayerStats aux = other.GetComponent<PlayerStats>();
        aux.ReciveDamage(5);
        damaged = true;
    }

    /// <summary>
    /// once the damage is done it cannot deal damage again until its activated again
    /// </summary>
    /// <returns></returns>
    private IEnumerator UnableAttack()
    {
        yield return new WaitForSeconds(0.5f);

        this.gameObject.SetActive(false);
    }
}
