using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CubeController : MonoBehaviour
{

    public InputField height;

    public void StartFall(){
        gameObject.GetComponent<Rigidbody>().useGravity = true;
    }

    public void ResetFall(){
        gameObject.GetComponent<Rigidbody>().useGravity = false;
        float value = float.Parse(height.text);
        gameObject.transform.localPosition = new Vector3(0f, value, 0f);
    }
}
