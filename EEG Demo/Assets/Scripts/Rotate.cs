using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rotate : MonoBehaviour
{

    public Slider rotateSlider;
    // Start is called before the first frame update
    void Start()
    {
        rotateSlider = GameObject.Find("RotationSlider").GetComponent<Slider>();
        rotateSlider.minValue = 0;
        rotateSlider.maxValue = 360;
        rotateSlider.onValueChanged.AddListener(RotateSliderUpdate);
       
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    void RotateSliderUpdate(float value)
    {
        var rotate = new Vector3(0, (int)value, 0);
        this.transform.Rotate(rotate * 1 * Time.deltaTime);
    }
}
