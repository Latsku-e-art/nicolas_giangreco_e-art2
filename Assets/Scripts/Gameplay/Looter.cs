using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Looter : MonoBehaviour
{
    bool Collide(int layer) {
        string name = LayerMask.LayerToName(layer);
        return name == "Neutral";
    }

    void OnTriggerEnter(Collider other) {

        if (Collide(other.gameObject.layer)) {

            GetComponentInParent<PlayerBoost>()?.Enter();

            Destroy(other.gameObject);
            
        }
    }
}
