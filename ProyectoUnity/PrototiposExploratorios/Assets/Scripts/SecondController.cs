using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondController : MonoBehaviour
{
    public GameObject surface;

    public void chageCubeFriction(float value){
        gameObject.GetComponent<BoxCollider>().material.dynamicFriction = value;
    }

    public void chageSurfaceFriction(float value){
        surface.GetComponent<BoxCollider>().material.dynamicFriction = value;
    }

    public void resetCube(){
        gameObject.transform.localPosition = new Vector3(-6.16f, 4.49f, 0f);
        gameObject.transform.localRotation = new Quaternion(0f, 0f, -20f, 0f);
    }
}
