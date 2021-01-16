using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerUltra : MonoBehaviour
{
    public SuperGun[] superGuns = new SuperGun[0];

    public float duration = 2f;

    public float progress = 0f;

    public bool isActive = false;

    public void EnterUltra(){
        
        

        foreach(var superGun in superGuns){
            superGun.enabled = true;
            
        }    
    }

    public void ExitUltra(){
        
        

        foreach(var superGun in superGuns){
            superGun.enabled = false;
            
        }
    }

    Collider ultra;

    void Start(){

        ultra = GetComponent<Collider>();
        
    
    }

    void Update(){

        if (enabled){

            progress += Time.deltaTime;
            
            EnterUltra();
            
        }else{
          
            ExitUltra();
        }

        if (progress >= duration){

            ExitUltra();

        }

    }
    

}
