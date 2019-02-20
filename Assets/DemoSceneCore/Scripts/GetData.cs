using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Grandma;
public class GetData : MonoBehaviour
{
    protected TextMeshProUGUI tmp;
    // Start is called before the first frame update
    void Start()
    {
        tmp = GetComponent<TextMeshProUGUI>();
    }

    protected virtual string GetString(){ return ""; }
    // Update is called once per frame

}
