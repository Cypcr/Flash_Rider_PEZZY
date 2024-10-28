using System.Collections;
using UnityEngine;

public class InvincibilityController : MonoBehaviour
{
    private bool _isInvincible;

    public void StartInvincibility(float invincibilityDuration)
    {
        StartCoroutine(InvincibilityCoroutine(invincibilityDuration));
    }

    private IEnumerator InvincibilityCoroutine(float invincibilityDuration)
    {
        _isInvincible = true;
        Debug.Log("Player is now invincible.");
        yield return new WaitForSeconds(invincibilityDuration);
        _isInvincible = false;
        Debug.Log("Player's invincibility has ended.");
    }

    public bool IsInvincible()
    {
        return _isInvincible;
    }
}
