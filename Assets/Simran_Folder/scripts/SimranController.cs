using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SimranController : MonoBehaviour
{
    [SerializeField]
    private Slider scaleSlider;
    [SerializeField]
    private Slider rotateSlider;
    [SerializeField] float scaleMinValue;
    [SerializeField] float scaleMaxValue;
    [SerializeField] float rotMinValue;
    [SerializeField] float rotMaxValue;
    public SimranSpawner spawner;

    void Start() 
    { 

        scaleSlider.minValue = scaleMinValue;
        scaleSlider.maxValue = scaleMaxValue;

        scaleSlider.onValueChanged.AddListener(ScaleSliderUpdate);

        rotateSlider.minValue = rotMinValue;
        rotateSlider.maxValue = rotMaxValue;

        rotateSlider.onValueChanged.AddListener(RotateSliderUpdate);


    }

    void ScaleSliderUpdate(float value)
    {
        if (spawner.gernatedCat != null)
        {
            spawner.gernatedCat.transform.localScale = new Vector3(value, value, value);
        }
    }

    void RotateSliderUpdate(float value)
    {
        if (spawner.gernatedCat != null)
        {
            spawner.gernatedCat.transform.localEulerAngles = new Vector3(transform.rotation.x, value, transform.rotation.z);
        }
    }
}
