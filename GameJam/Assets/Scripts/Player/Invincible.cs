using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invincible : Upgrade
{
    void Start()
    {
        timer = 8f;
    }

    void Update()
    {
        if (!active) return;

        if (timer == 8f)
        {
            player.GetComponent<PlayerController>().SetInvincible(true);
        }

        timer -= Time.deltaTime;
        icon.fillAmount -= Time.deltaTime / 8f;

        if (timer < 0)
        {
            player.GetComponent<PlayerController>().SetInvincible(false);
            player.GetComponent<PlayerUpgrades>().Remove(this);
            Destroy(gameObject);
        }
    }
}
