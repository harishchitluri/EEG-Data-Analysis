using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectTest : MonoBehaviour
{
    public GameObject head;
    public GameObject brain;
    public GameObject headbrain;
    public GameObject Models3D;
    //private GameObject currentActiveObject;

    private Vector3 rotate;
    private int prevRotSliderValue;
    public Slider transparencySlider;

    public Material headMaterial;
    public Material brainMaterial;
    public Material headbrainMaterial;

    public ToggleGroup objectToggleGroup;
    private Toggle activeToggle;
    //public ToggleGroup channelToggleGroup;
    bool setTrans = false;

    Slider VRSlider;
    Slider HRSlider;
    // Start is called before the first frame update
    void Start()
    {
        head.SetActive(true);
        brain.SetActive(false);
        headbrain.SetActive(false);
        activeToggle = objectToggleGroup.GetFirstActiveToggle();
        //VRSlider = GameObject.Find("RotationSlider V").GetComponent<Slider>();
        //HRSlider = GameObject.Find("RotationSlider").GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        //activeToggle = objectToggleGroup.GetFirstActiveToggle();
        

    }

    public void Object3DSelected(string modelName)
    {
        if (modelName.Equals("Head"))
        {
            head.SetActive(true);
            transparencySlider.enabled = false; ;
            brain.SetActive(false);
            headbrain.SetActive(false);
        }

        else if (modelName.Equals("Brain"))
        {
            brain.SetActive(true);
            if (!setTrans)
            {
                transparencySlider.enabled = true;
                transparencySlider.value = brainMaterial.color.a;
                setTrans = true;
            }
            head.SetActive(false);
            headbrain.SetActive(false);
        }

        else if (modelName.Equals("Head & Brain"))
        {
            headbrain.SetActive(true);
            if (!setTrans)
            {
                transparencySlider.enabled = true;
                transparencySlider.value = headbrainMaterial.color.a;
                setTrans = true;
            }
            head.SetActive(false);
            brain.SetActive(false);
        }
    }

    public void TransparencyChanged(float currentSliderValue)
    {

        if (activeToggle.name.Equals("Brain"))
        {
            Color color = brainMaterial.color;
            color.a = currentSliderValue; ;
            brainMaterial.color = color;
        }

        else if (activeToggle.name.Equals("Head & Brain"))
        {
            Color color = headbrainMaterial.color;
            color.a = (int)currentSliderValue; ;
            headbrainMaterial.color = color;
        }

    }

    public void RotationChanged(float currentSliderValue)
    {
        //VRSlider.gameObject.SetActive(false);
        //VRSlider.value = 0;
        //VRSlider.gameObject.SetActive(true);
        Models3D.transform.rotation = Quaternion.Euler(Models3D.transform.rotation.x, -(int)(currentSliderValue), Models3D.transform.rotation.z);
    }

    public void RotationChangedV(float currentSliderValue)
    {
        //var VRSlider = GameObject.Find("RotationSlider").GetComponent<Slider>();
        //VRSlider.gameObject.SetActive(false);
        //VRSlider.value = 0;
        //VRSlider.gameObject.SetActive(true);
        Models3D.transform.rotation = Quaternion.Euler(Models3D.transform.rotation.x, Models3D.transform.rotation.y, (int)(currentSliderValue));
    }
}
