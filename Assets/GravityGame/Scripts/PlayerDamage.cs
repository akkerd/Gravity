using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerDamage : MonoBehaviour {


    public int lives;
    public float invulnerability = 1.0f;
    public float flashDuration = 0.1f;
    public Text loseText;

    private bool invulnerable = false;

    public void TakeDamage(int damage)
    {
        if (!invulnerable)
        {
            this.lives -= damage;
            StartCoroutine(CharacterFlash());
            if (lives <= 0)
            {
                loseText.enabled = true;
            }
        }
    }

    private IEnumerator CharacterFlash()
    {
        invulnerable = true;

        for (float i = 0.0f; i < invulnerability; i += flashDuration)
        {
            yield return new WaitForSeconds(flashDuration);
            this.GetComponent<SpriteRenderer>().enabled = false;
            yield return new WaitForSeconds(flashDuration);
            this.GetComponent<SpriteRenderer>().enabled = true;
        }
        invulnerable = false;
    }

}
