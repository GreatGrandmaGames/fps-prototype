using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Grandma;
using Grandma.ParametricFirearms;
public class GetAmmoString : GetData
{
    public ParametricFirearm pf;
    protected override string GetString()
    {
        string s = "";
        s += pf.CurrentAmmo.ToString();
        s += " / ";
        s += pf.PFData.RateOfFire.AmmoCapacity.ToString();
        return s;
    }
    // Update is called once per frame
    void Update()
    {
        tmp.text = GetString();
    }
}
