﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Grandma.ParametricFirearms;
public class PlayerPFController : MonoBehaviour {

    [HideInInspector]
    public ParametricFirearm pf;
    public KeyCode reload;
    private void Start()
    {
        pf = GetComponent<ParametricFirearm>();
    }
    // Update is called once per frame
    void Update ()
    {
        if(pf == null)
        {
            return;
        }

        if (Input.GetMouseButtonDown(0))
        {
            pf.TriggerPress();
        }

        if (Input.GetMouseButtonUp(0))
        {
            pf.TriggerRelease();
        }

        if (Input.GetKeyDown(reload))
        {
            if (pf.State == ParametricFirearm.PFState.ManualReload)
            {
                pf.CancelManualReload();
            }
            else
            {
                pf.ManualReload();
            }
        }
    }
}
