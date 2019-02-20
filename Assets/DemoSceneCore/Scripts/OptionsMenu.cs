using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsMenu : MonoBehaviour
{
    public GameObject OptionsMenuPrefab;

    // Update is called once per frame
    void CreateOptions()
    {
        Instantiate(OptionsMenuPrefab).transform.parent = transform;
    }
}
