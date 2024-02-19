using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FishNet.Connection;
using FishNet.Object;
using TMPro;

public class PlayerStats : NetworkBehaviour
{
    public int health;
    public TMP_Text uiDisplay;


    /// <summary>
    /// Is called from the collider to deal damage to the player
    /// </summary>
    /// <param name="damageAmount"></param>
    public void ReciveDamage(int damageAmount)
    {
        ReciveDamageServerRpc(damageAmount);
    }

    /// <summary>
    /// Substracts health from the player
    /// </summary>
    /// <param name="damageAmount"></param>
    [ObserversRpc]
    private void ReciveDamageObserversRpc(int damageAmount)
    {
        if (health > 0)
            health -= damageAmount;
        else
            Die();
        uiDisplay.text = health.ToString();
    }

    [ServerRpc]
    private void ReciveDamageServerRpc(int damageAmount)
    {
        ReciveDamageObserversRpc(damageAmount);
    }
    private void Die()
    {
        health = 0;
    }
}
