using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldLooter : MonoBehaviour
{
    public GameObject invincibleG;

    bool Collide(int layer) {
        string name = LayerMask.LayerToName(layer);
        return name == "Shield";
    }

    void OnTriggerEnter(Collider other) {

        if (Collide(this.gameObject.layer)) {
            
            invincibleG.GetComponent<PlayerShield>()?.EnterShield();

            Debug.Log("JE FONCTIONNE MAIS J'ACTIVE PAS LE CODE !");

            Destroy(this.gameObject);
            
            
        }
    }
}
