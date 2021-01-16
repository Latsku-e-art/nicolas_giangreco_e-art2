using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShield : MonoBehaviour
{
    public float duration = 2f;

    public float progress = 0f;

    public bool isActive = false;

    public SpriteRenderer spriteShield;

    
    public void EnterShield(){

        isActive = true;
        progress = 0f;
        //this.spriteShield.enabled = true;
    }

    public void ExitShield(){

        isActive = false;
        progress = 0f;
        //this.spriteShield.enabled = false;
    }

    Collider shield;

    void Start(){

        shield = GetComponent<Collider>();

        this.spriteShield = GetComponent<SpriteRenderer>();
    }

    void Update(){

        if (isActive){

            progress += Time.deltaTime;

            Player.player.invincible = true;
            shield.enabled = true;
            this.spriteShield.enabled = true;
            
        }else{

            Player.player.invincible = false;
            shield.enabled = false;
            this.spriteShield.enabled = false;
        }

        
        if (progress >= duration){

            ExitShield();

        }

       
    }
}
