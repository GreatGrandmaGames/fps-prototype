using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Grandma;
public class KillEnemy : MonoBehaviour
{
    private Damageable d;
    // Start is called before the first frame update
    void Start()
    {
        d = GetComponent<Damageable>();
    }

    // Update is called once per frame
    void KillMe()
    {
        Debug.Log("LMAO STOP IM DEAD");
        //Destroy(this.gameObject);
    }
}
