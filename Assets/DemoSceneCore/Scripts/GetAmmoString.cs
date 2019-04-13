using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Grandma;
using Grandma.ParametricFirearms;
public class GetAmmoString : GetData
{
    public PlayerPFController pf;
    protected override string GetString()
    {
        string s = "";
        s += pf.Current.CurrentAmmo.ToString();
        s += " / ";
        s += pf.Current.PFData.RateOfFire.AmmoCapacity.ToString();
        return s;
    }
    // Update is called once per frame
    void Update()
    {
        tmp.text = GetString();
    }
}
