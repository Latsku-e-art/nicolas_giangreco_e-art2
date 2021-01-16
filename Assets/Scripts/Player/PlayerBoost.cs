using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBoost : MonoBehaviour
{
    public float duration = 2f;

    public float progress = 0f;

    public bool isActive = false;

    public float boostValue = 1.5f;

    public SpriteRenderer flames;

    public void Enter(){

        isActive = true;
        progress = 0f;
    }

    public void Exit(){

        isActive = false;
        progress = 0f;
    }

    
    void Update(){

        if (isActive){

            progress += Time.deltaTime;
            Player.player.boost = boostValue;

            flames.enabled = true;
            

            
        }else{

            Player.player.boost = 1f;
            flames.enabled = false;
        }

        if (progress >= duration){

            Exit();

        }

       
    }
}
