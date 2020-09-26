using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ThirdController : MonoBehaviour
{

    [SerializeField] GameObject cube;
    [SerializeField] GameObject sphere;
    [SerializeField] GameObject capsule;
    [SerializeField] Slider sizeSlider;

    void Start(){
        cube.SetActive(true);
        sphere.SetActive(false);
        capsule.SetActive(false);
    }

    public void changeShape(int shape){
        if(shape == 0){
            sizeSlider.value = cube.transform.localScale.x;
            gameObject.transform.localPosition = new Vector3(0f, 0.69f, 0f);
            cube.SetActive(true);
            sphere.SetActive(false);
            capsule.SetActive(false);
        }else if(shape == 1){
            sizeSlider.value = sphere.transform.localScale.x;
            gameObject.transform.localPosition = new Vector3(0f, 0.69f, 0f);
            cube.SetActive(false);
            sphere.SetActive(true);
            capsule.SetActive(false);
        }else if(shape == 2){
            sizeSlider.value = capsule.transform.localScale.x;
            gameObject.transform.localPosition = new Vector3(0f, 1.15f, 0f);
            cube.SetActive(false);
            sphere.SetActive(false);
            capsule.SetActive(true);
        }
    }

    public void changeSize(float size){
        if(cube.activeInHierarchy) cube.transform.localScale = new Vector3(size, size, size);
        if(sphere.activeInHierarchy) sphere.transform.localScale = new Vector3(size, size, size);
        if(capsule.activeInHierarchy) capsule.transform.localScale = new Vector3(size, size, size);
    }
}
