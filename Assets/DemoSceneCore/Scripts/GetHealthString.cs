using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Grandma;
public class GetHealthString : GetData
{
    public Damageable player;
    protected override string GetString()
    {
        string s = "";
        s += player.CurrentHealth + " / ";
        s += player.MaxHealth;
        return s;
    }

    private void Update()
    {
        tmp.text = GetString();
    }
}
