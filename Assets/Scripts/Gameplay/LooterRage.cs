using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LooterRage : MonoBehaviour
{
     bool Collide(int layer) {
        string name = LayerMask.LayerToName(layer);
        return name == "Neutral";
    }

    void OnTriggerEnter(Collider other) {

        if (Collide(other.gameObject.layer)) {

            GetComponentInChildren<PlayerUltra>()?.EnterUltra();

            Destroy(other.gameObject);
            
        }
    }
}
