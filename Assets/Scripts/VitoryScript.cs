using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VitoryScript : MonoBehaviour
{
    public void OnCollisonEvent(Collider other){
        
        other.gameObject.GetComponent<DeathHandler>().HandleDeath();
    }
}
