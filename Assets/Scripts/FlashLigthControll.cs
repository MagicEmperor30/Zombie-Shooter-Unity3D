using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class FlashLigthControll : MonoBehaviour
{
    // [SerializeField] float ligthDecay = .1f;
    // [SerializeField] float angleDecay = 1f;
    // [SerializeField] float minimumAngle = 40f;
    Light myLight;

    public void Start(){
        myLight = GetComponent<Light>();
        myLight.enabled = false;
    } 
    public void Update(){
        if(Input.GetKey(KeyCode.F)){
            myLight.enabled = !myLight.enabled;
        }
    }
    // public void RestoreLightAngle(float restoreAngle)
    // {
    //     myLight.spotAngle = restoreAngle;
    // } 

    // public void AddLightIntensity(float intensityAmount)
    // {
    //     myLight.intensity += intensityAmount;
    // }
    // private void DecreaseLightIntensity()
    // {
    //     if(myLight.spotAngle <= minimumAngle)
    //     {
    //         return;
    //     }else{
    //         myLight.spotAngle -= angleDecay * Time.deltaTime;
    //     }
    // }

    // private void DecreaseLightAngle()
    // {
    //     myLight.intensity -= ligthDecay * Time.deltaTime;
    // }
}
