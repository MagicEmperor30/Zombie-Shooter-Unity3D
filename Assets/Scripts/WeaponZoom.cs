using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class WeaponZoom : MonoBehaviour
{
    [SerializeField] CinemachineVirtualCamera Fpscamera;
    [SerializeField] float zoomOutFOV = 60f;
    [SerializeField] float zoomInFOV = 30f;
    public WeaponSwitcher weaponSwitcher;

    void Start(){
        weaponSwitcher = FindObjectOfType<WeaponSwitcher>();
    }
    bool zoomInToggle = false;
    public void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            if(zoomInToggle == false)
            {
                zoomInToggle = true;
                Fpscamera.m_Lens.FieldOfView = zoomInFOV;
                weaponSwitcher.enabled = false;
            }else
            {
                zoomInToggle = false;
                Fpscamera.m_Lens.FieldOfView = zoomOutFOV;
                weaponSwitcher.enabled = true;
            }
        }
    }
}
