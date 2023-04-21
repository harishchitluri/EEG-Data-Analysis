using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.IO;
using System.Globalization;
using System;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Light F7;
    public Light BF7;
    public Light F8;
    public Light BF8;
    public Light TP7;
    public Light BTP7;
    public Light TP8;
    public Light BTP8;
    public Light Fp1;
    public Light Fp2;
    public Light BFp1;
    public Light BFp2;

    public Light F3;
    public Light BF3;
    public Light F4;
    public Light BF4;
    public Light Fz;
    public Light BFz;
    public Light Fc4;
    public Light BFc4;
    public Light Fc3;
    public Light BFc3;
    public Light Fcz;
    public Light BFcz;

    public Light Ft7;
    public Light BFt7;
    public Light Ft8;
    public Light BFt8;
    public Light C4;
    public Light BC4;
    public Light C3;
    public Light BC3;
    public Light Cz;
    public Light BCz;
    public Light T7;
    public Light BT7;

    public Light T8;
    public Light BT8;
    public Light Cp4;
    public Light BCp4;
    public Light Cp3;
    public Light BCp3;
    public Light Cpz;
    public Light BCpz;
    public Light P4;
    public Light BP4;
    public Light P3;
    public Light BP3;

    public Light Pz;
    public Light BPz;
    public Light P7;
    public Light BP7;
    public Light P8;
    public Light BP8;
    public Light O1;
    public Light BO1;
    public Light Oz;
    public Light BOz;
    public Light O2;
    public Light BO2;

    public Light A2;
    public Light BA2;
    public Light A1;
    public Light BA1;

    public TextMeshPro c1Text;
    public TextMeshPro c2Text;
    public TextMeshPro c3Text;
    public TextMeshPro c4Text;
    public TextMeshPro c5Text;
    public TextMeshPro c6Text;
    public TextMeshPro c7Text;
    public TextMeshPro c8Text;

    public TextMeshPro c1label;
    public TextMeshPro c2label;
    public TextMeshPro c3label;
    public TextMeshPro c4label;
    public TextMeshPro c5label;
    public TextMeshPro c6label;
    public TextMeshPro c7label;
    public TextMeshPro c8label;

    public Toggle tF7;
    public Toggle tF8;
    public Toggle tTP7;
    public Toggle tTP8;
    public Toggle tFp1;
    public Toggle tFp2;
    public Toggle tF3;
    public Toggle tF4;
    public Toggle tFz;
    public Toggle tFc4;
    public Toggle tFc3;
    public Toggle tFcz;
    public Toggle tFt7;
    public Toggle tFt8;
    public Toggle tC4;
    public Toggle tC3;
    public Toggle tCz;
    public Toggle tT7;
    public Toggle tT8;
    public Toggle tCp4;
    public Toggle tCp3;
    public Toggle tCpz;
    public Toggle tP4;
    public Toggle tP3;
    public Toggle tPz;
    public Toggle tP7;
    public Toggle tP8;
    public Toggle tO1;
    public Toggle tOz;
    public Toggle tO2;

    private static int speedValue = 2;
    private StreamReader reader;
    private bool eof;
    private int prevSliderValue = 2;
    private static int currChnalleSize = 4;

    void Start()
    {
        reader = new StreamReader("D:\\MCBCSCST23\\EEG with misc\\EEG Demo\\Assets\\EEG Data\\x_np1T.csv");
        eof = false;

            F7.color = Color.red;
            F7.enabled = true;
            BF7.color = Color.red;
            BF7.enabled = true;
            F8.color = Color.green;
            F8.enabled = true;
            BF8.color = Color.green;
            BF8.enabled = true;
            TP7.color = Color.blue;
            TP7.enabled = true;
            BTP7.color = Color.blue;
            BTP7.enabled = true;
            TP8.color = Color.yellow;
            TP8.enabled = true;
            BTP8.color = Color.yellow;
            BTP8.enabled = true;
            Fp1.enabled = false;
            Fp2.enabled = false;
            BFp1.enabled = false;
            BFp2.enabled = false;

            F3.enabled = false; 
            BF3.enabled = false; 
            F4.enabled = false;
            BF4.enabled = false;
            Fz.enabled = false;
            BFz.enabled = false;
            Fc4.enabled = false;
            BFc4.enabled = false;
            Fc3.enabled = false;
            BFc3.enabled = false;
            Fcz.enabled = false;
            BFcz.enabled = false;

            Ft7.enabled = false; 
            BFt7.enabled = false; 
            Ft8.enabled = false;
            BFt8.enabled = false;
            C4.enabled = false;
            BC4.enabled = false;
            C3.enabled = false;
            BC3.enabled = false;
            Cz.enabled = false;
            BCz.enabled = false;
            T7.enabled = false;
            BT7.enabled = false;

            T8.enabled = false;
            BT8.enabled = false;
            Cp4.enabled = false;
            BCp4.enabled = false;
            Cp3.enabled = false;
            BCp3.enabled = false;
            Cpz.enabled = false;
            BCpz.enabled = false;
            P4.enabled = false;
            BP4.enabled = false;
            P3.enabled = false;
            BP3.enabled = false;

            Pz.enabled = false;
            BPz.enabled = false;
            P7.enabled = false;
            BP7.enabled = false;
            P8.enabled = false;
            BP8.enabled = false;
            O1.enabled = false;
            BO1.enabled = false;
            Oz.enabled = false;
            BOz.enabled = false;
            O2.enabled = false;
            BO2.enabled = false;

            A2.enabled = true;
            BA2.enabled = true;
            A1.enabled = true;
            BA1.enabled = true;

        c1label.text = "F7";
        c1Text.color = F7.color;
        c2label.text = "F8";
        c2Text.color = F8.color;
        c3label.text = "TP7";
        c3Text.color = TP7.color;
        c4label.text = "TP8";
        c4Text.color = TP8.color;
        c5label.text = "-";
        c6label.text = "-";
        c7label.text = "-";
        c8label.text = "-";

         tF7.enabled = true;
         tF8.enabled = true; 
         tTP7.enabled = true; 
         tTP8.enabled = true; 
         tFp1.enabled = false; 
         tFp2.enabled = false;
         tF3.enabled = false;
         tF4.enabled = false;
         tFz.enabled = false;
         tFc4.enabled = false;
         tFc3.enabled = false;
         tFcz.enabled = false;
         tFt7.enabled = false;
         tFt8.enabled = false;
         tC4.enabled = false;
         tC3.enabled = false;
         tCz.enabled = false;
         tT7.enabled = false;
         tT8.enabled = false;
         tCp4.enabled = false;
         tCp3.enabled = false;
         tCpz.enabled = false;
         tP4.enabled = false;
         tP3.enabled = false;
         tPz.enabled = false;
         tP7.enabled = false;
         tP8.enabled = false;
         tO1.enabled = false;
         tOz.enabled = false;
         tO2.enabled = false;

}

    void Update()
    {
        var condaEP = (Time.frameCount % (int)(16 / speedValue));
        if ((condaEP == 0) && (!eof))
        {
            string data_string = reader.ReadLine();
            if (data_string == null)
            {
                eof = true;
            }
            else
            {
                var data_values = data_string.Split(',');

                if (currChnalleSize == 4)
                {
                    F7.intensity = (((float.Parse(data_values[5]) + (float)12.013)) * ((float)0.227));
                    BF7.intensity = F7.intensity / 4;
                    c1Text.text = F7.intensity.ToString("#.###");

                    F8.intensity = (((float.Parse(data_values[13]) + (float)12.013)) * ((float)0.227)); 
                    BF8.intensity = F8.intensity / 4;
                    c2Text.text = F7.intensity.ToString("#.###");

                    TP7.intensity = (((float.Parse(data_values[32]) + (float)12.013)) * ((float)0.227));
                    BTP7.intensity = TP7.intensity / 4;
                    c3Text.text = F7.intensity.ToString("#.###");

                    TP8.intensity = (((float.Parse(data_values[40]) + (float)12.013)) * ((float)0.227));
                    BTP8.intensity = TP8.intensity / 4;
                    c4Text.text = F7.intensity.ToString("#.###");
                }
                else if (currChnalleSize == 8)
                {
                    Fp1.intensity = (((float.Parse(data_values[0]) + (float)12.013)) * ((float)0.227)); 
                    BFp1.intensity = Fp1.intensity/4;
                    c1Text.text = Fp1.intensity.ToString("#.###");

                    Fp2.intensity = (((float.Parse(data_values[2]) + (float)12.013)) * ((float)0.227)); 
                    BFp2.intensity = Fp2.intensity > 0.5f ? 0.5f : (Fp2.intensity / 4);
                    c2Text.text = Fp2.intensity.ToString("#.###");

                    C4.intensity = (((float.Parse(data_values[29]) + (float)12.013)) * ((float)0.227)); 
                    BC4.intensity = C4.intensity/4;
                    c3Text.text = C4.intensity.ToString("#.###");

                    C3.intensity = (((float.Parse(data_values[25]) + (float)12.013)) * ((float)0.227)); 
                    BC3.intensity = C3.intensity/4;
                    c4Text.text = C3.intensity.ToString("#.###");

                    T7.intensity = (((float.Parse(data_values[23]) + (float)12.013)) * ((float)0.227)); 
                    BT7.intensity = T7.intensity/4;
                    c5Text.text = T7.intensity.ToString("#.###");

                    T8.intensity = (((float.Parse(data_values[31]) + (float)12.013)) * ((float)0.227));
                    BT8.intensity = T8.intensity/4;
                    c6Text.text = T8.intensity.ToString("#.###");

                    O1.intensity = (((float.Parse(data_values[58]) + (float)12.013)) * ((float)0.227));
                    BO1.intensity = O1.intensity/4;
                    c7Text.text = O1.intensity.ToString("#.###");

                    O2.intensity = (((float.Parse(data_values[61]) + (float)12.013)) * ((float)0.227));
                    BO2.intensity = O2.intensity/4;
                    c8Text.text = O2.intensity.ToString("#.###");
                }

                else if (currChnalleSize == 32)
                {
                    F7.intensity = (((float.Parse(data_values[5]) + (float)12.013)) * ((float)0.227));
                    BF7.intensity = F7.intensity / 4;
                    F8.intensity = (((float.Parse(data_values[13]) + (float)12.013)) * ((float)0.227));
                    BF8.intensity = F8.intensity / 4;
                    TP7.intensity = (((float.Parse(data_values[32]) + (float)12.013)) * ((float)0.227));
                    BTP7.intensity = TP7.intensity / 4;
                    TP8.intensity = (((float.Parse(data_values[40]) + (float)12.013)) * ((float)0.227));
                    BTP8.intensity = TP8.intensity / 4;
                    Fp1.intensity = (((float.Parse(data_values[0]) + (float)12.013)) * ((float)0.227));
                    BFp1.intensity = Fp1.intensity / 4;
                    Fp2.intensity = (((float.Parse(data_values[2]) + (float)12.013)) * ((float)0.227));
                    BFp2.intensity = Fp2.intensity / 4;
                    C4.intensity = (((float.Parse(data_values[29]) + (float)12.013)) * ((float)0.227));
                    BC4.intensity = C4.intensity / 4;
                    C3.intensity = (((float.Parse(data_values[25]) + (float)12.013)) * ((float)0.227));
                    BC3.intensity = C3.intensity / 4;
                    T7.intensity = (((float.Parse(data_values[23]) + (float)12.013)) * ((float)0.227));
                    BT7.intensity = T7.intensity / 4;
                    T8.intensity = (((float.Parse(data_values[31]) + (float)12.013)) * ((float)0.227));
                    BT8.intensity = T8.intensity / 4;
                    O1.intensity = (((float.Parse(data_values[58]) + (float)12.013)) * ((float)0.227));
                    BO1.intensity = O1.intensity / 4;
                    O2.intensity = (((float.Parse(data_values[61]) + (float)12.013)) * ((float)0.227));
                    BO2.intensity = O2.intensity / 4;

                    F3.intensity = (((float.Parse(data_values[7]) + (float)12.013)) * ((float)0.227));
                    BF3.intensity = F3.intensity / 4;
                    F4.intensity = (((float.Parse(data_values[11]) + (float)12.013)) * ((float)0.227));
                    BF4.intensity = F4.intensity / 4;
                    Fz.intensity = (((float.Parse(data_values[9]) + (float)12.013)) * ((float)0.227));
                    BFz.intensity = Fz.intensity / 4;
                    Fc4.intensity = (((float.Parse(data_values[20]) + (float)12.013)) * ((float)0.227));
                    BFc4.intensity = Fc4.intensity / 4;
                    Fc3.intensity = (((float.Parse(data_values[16]) + (float)12.013)) * ((float)0.227));
                    BFc3.intensity = Fc3.intensity / 4;
                    Fcz.intensity = (((float.Parse(data_values[18]) + (float)12.013)) * ((float)0.227));
                    BFcz.intensity = Fcz.intensity / 4;

                    Ft7.intensity = (((float.Parse(data_values[14]) + (float)12.013)) * ((float)0.227));
                    BFt7.intensity = Ft7.intensity / 4;
                    Ft8.intensity = (((float.Parse(data_values[22]) + (float)12.013)) * ((float)0.227));
                    BFt8.intensity = Ft8.intensity / 4;

                    Cp4.intensity = (((float.Parse(data_values[38]) + (float)12.013)) * ((float)0.227));
                    BCp4.intensity = Cp4.intensity / 4;
                    Cp3.intensity = (((float.Parse(data_values[34]) + (float)12.013)) * ((float)0.227));
                    BCp3.intensity = Cp3.intensity / 4;
                    Cpz.intensity = (((float.Parse(data_values[36]) + (float)12.013)) * ((float)0.227));
                    BCpz.intensity = Cpz.intensity / 4;
                    P4.intensity = (((float.Parse(data_values[47]) + (float)12.013)) * ((float)0.227));
                    BP4.intensity = P4.intensity / 4;
                    P3.intensity = (((float.Parse(data_values[43]) + (float)12.013)) * ((float)0.227));
                    BP3.intensity = P3.intensity / 4;

                    Pz.intensity = (((float.Parse(data_values[45]) + (float)12.013)) * ((float)0.227));
                    BPz.intensity = Pz.intensity / 4;
                    P7.intensity = (((float.Parse(data_values[41]) + (float)12.013)) * ((float)0.227));
                    BP7.intensity = P7.intensity / 4;
                    P8.intensity = (((float.Parse(data_values[49]) + (float)12.013)) * ((float)0.227));
                    BP8.intensity = P8.intensity / 4;

                    Oz.intensity = (((float.Parse(data_values[53]) + (float)12.013)) * ((float)0.227));
                    BOz.intensity = Oz.intensity / 4;


                    //BA1.enabled = !BA1.enabled;
                    //BA2.enabled = !BA2.enabled;

                    c1Text.text = Fp1.intensity.ToString("#.###");

                    c2Text.text = Fp2.intensity.ToString("#.###");

                    c3Text.text = C4.intensity.ToString("#.###");

                    c4Text.text = C3.intensity.ToString("#.###");

                    c5Text.text = T7.intensity.ToString("#.###");

                    c6Text.text = T8.intensity.ToString("#.###");

                    c7Text.text = O1.intensity.ToString("#.###");

                    c8Text.text = O2.intensity.ToString("#.###");
                }
                A2.enabled = !A2.enabled;
                A1.enabled = !A1.enabled;
            }
        }
    }

    public void OnValueChanged(float currentSliderValue)
    { 
        // min speedValue = 0.25, max speedValue = 12
        // if slider moves to the left reduce the speed by 0.5
        if (prevSliderValue > (int)currentSliderValue)
        {
            if((prevSliderValue - (int)currentSliderValue) == 0)
            {
                speedValue = 1;
            }
            else
            {
                speedValue = (int)speedValue / (2 * (prevSliderValue - (int)currentSliderValue));
            }
            
        }
        //else increase the speed by 2
        else if (prevSliderValue < (int)currentSliderValue)
        {
            speedValue = (int)speedValue * (2 * ((int)currentSliderValue - prevSliderValue));
        }
        prevSliderValue = (int)currentSliderValue;
    }

    public void VisibleChannelsChanged(int number)
    {
        if (number == 4)
        {
            currChnalleSize = number;

            F7.color = Color.red;
            F7.enabled = true;
            BF7.color = Color.red;
            BF7.enabled = true;
            F8.color = Color.green;
            F8.enabled = true;
            BF8.color = Color.green;
            BF8.enabled = true;
            TP7.color = Color.blue;
            TP7.enabled = true;
            BTP7.color = Color.blue;
            BTP7.enabled = true;
            TP8.color = Color.yellow;
            TP8.enabled = true;
            BTP8.color = Color.yellow;
            BTP8.enabled = true;
            Fp1.enabled = false;
            Fp2.enabled = false;
            BFp1.enabled = false;
            BFp2.enabled = false;

            F3.enabled = false;
            BF3.enabled = false;
            F4.enabled = false;
            BF4.enabled = false;
            Fz.enabled = false;
            BFz.enabled = false;
            Fc4.enabled = false;
            BFc4.enabled = false;
            Fc3.enabled = false;
            BFc3.enabled = false;
            Fcz.enabled = false;
            BFcz.enabled = false;

            Ft7.enabled = false;
            BFt7.enabled = false;
            Ft8.enabled = false;
            BFt8.enabled = false;
            C4.enabled = false;
            BC4.enabled = false;
            C3.enabled = false;
            BC3.enabled = false;
            Cz.enabled = false;
            BCz.enabled = false;
            T7.enabled = false;
            BT7.enabled = false;

            T8.enabled = false;
            BT8.enabled = false;
            Cp4.enabled = false;
            BCp4.enabled = false;
            Cp3.enabled = false;
            BCp3.enabled = false;
            Cpz.enabled = false;
            BCpz.enabled = false;
            P4.enabled = false;
            BP4.enabled = false;
            P3.enabled = false;
            BP3.enabled = false;

            Pz.enabled = false;
            BPz.enabled = false;
            P7.enabled = false;
            BP7.enabled = false;
            P8.enabled = false;
            BP8.enabled = false;
            O1.enabled = false;
            BO1.enabled = false;
            Oz.enabled = false;
            BOz.enabled = false;
            O2.enabled = false;
            BO2.enabled = false;

            A2.enabled = false;
            BA2.enabled = false;
            A1.enabled = false;
            BA1.enabled = false;

            c1label.text = "F7";
            c1Text.color = F7.color;
            c2label.text = "F8";
            c2Text.color = F8.color;
            c3label.text = "TP7";
            c3Text.color = TP7.color;
            c4label.text = "TP8";
            c4Text.color = TP8.color;
            c5label.text = "";
            c6label.text = "";
            c7label.text = "";
            c8label.text = "";
            c5Text.text = "";
            c6Text.text = "";
            c7Text.text = "";
            c8Text.text = "";

            tF7.isOn = true;
            tF8.isOn = true;
            tTP7.isOn = true;
            tTP8.isOn = true;
            tFp1.isOn = true;
            tFp2.isOn = true;
            tF3.isOn = true;
            tF4.isOn = true;
            tFz.isOn = true;
            tFc4.isOn = true;
            tFc3.isOn = true;
            tFcz.isOn = true;
            tFt7.isOn = true;
            tFt8.isOn = true;
            tC4.isOn = true;
            tC3.isOn = true;
            tCz.isOn = true;
            tT7.isOn = true;
            tT8.isOn = true;
            tCp4.isOn = true;
            tCp3.isOn = true;
            tCpz.isOn = true;
            tP4.isOn = true;
            tP3.isOn = true;
            tPz.isOn = true;
            tP7.isOn = true;
            tP8.isOn = true;
            tO1.isOn = true;
            tOz.isOn = true;
            tO2.isOn = true;

            tF7.enabled = true;
            tF8.enabled = true;
            tTP7.enabled = true;
            tTP8.enabled = true;
            tFp1.enabled = false;
            tFp2.enabled = false;
            tF3.enabled = false;
            tF4.enabled = false;
            tFz.enabled = false;
            tFc4.enabled = false;
            tFc3.enabled = false;
            tFcz.enabled = false;
            tFt7.enabled = false;
            tFt8.enabled = false;
            tC4.enabled = false;
            tC3.enabled = false;
            tCz.enabled = false;
            tT7.enabled = false;
            tT8.enabled = false;
            tCp4.enabled = false;
            tCp3.enabled = false;
            tCpz.enabled = false;
            tP4.enabled = false;
            tP3.enabled = false;
            tPz.enabled = false;
            tP7.enabled = false;
            tP8.enabled = false;
            tO1.enabled = false;
            tOz.enabled = false;
            tO2.enabled = false;
        }

        else if (number == 8)
        {
            currChnalleSize = number;

            F7.enabled = false;
            BF7.enabled = false;
            F8.enabled = false;
            BF8.enabled = false;
            TP7.enabled = false;
            BTP7.enabled = false;
            TP8.enabled = false;
            BTP8.enabled = false;
            Fp1.color = Color.red; 
            Fp1.enabled = true;
            Fp2.color = Color.green;
            Fp2.enabled = true;
            BFp1.color = Color.red;
            BFp1.enabled = true;
            BFp2.color = Color.green;
            BFp2.enabled = true;

            F3.enabled = false;
            BF3.enabled = false;
            F4.enabled = false;
            BF4.enabled = false;
            Fz.enabled = false;
            BFz.enabled = false;
            Fc4.enabled = false;
            BFc4.enabled = false;
            Fc3.enabled = false;
            BFc3.enabled = false;
            Fcz.enabled = false;
            BFcz.enabled = false;

            Ft7.enabled = false;
            BFt7.enabled = false;
            Ft8.enabled = false;
            BFt8.enabled = false;
            //C4.color = Color.white;
            C4.enabled = true;
            //BC4.color = Color.white; 
            BC4.enabled = true;
            //C3.color = Color.gray;
            C3.enabled = true;
            //BC3.color = Color.gray;
            BC3.enabled = true;
            Cz.enabled = false;
            BCz.enabled = false;
            T7.color = Color.blue;
            T7.enabled = true;
            BT7.color = Color.blue;
            BT7.enabled = true;

            T8.color = Color.yellow;
            T8.enabled = true;
            BT8.color = Color.yellow;
            BT8.enabled = true;
            Cp4.enabled = false;
            BCp4.enabled = false;
            Cp3.enabled = false;
            BCp3.enabled = false;
            Cpz.enabled = false;
            BCpz.enabled = false;
            P4.enabled = false;
            BP4.enabled = false;
            P3.enabled = false;
            BP3.enabled = false;

            Pz.enabled = false;
            BPz.enabled = false;
            P7.enabled = false;
            BP7.enabled = false;
            P8.enabled = false;
            BP8.enabled = false;
            O1.color = Color.magenta;
            O1.enabled = true;
            BO1.color = Color.magenta;
            BO1.enabled = true;
            Oz.enabled = false;
            BOz.enabled = false;
            O2.color = Color.cyan;
            O2.enabled = true;
            BO2.color = Color.cyan;
            BO2.enabled = true;

            A2.enabled = false;
            BA2.enabled = false;
            A1.enabled = false;
            BA1.enabled = false;

            c1label.text = "Fp1";
            c1Text.color = Fp1.color;
            c2label.text = "Fp2";
            c2Text.color = Fp2.color;
            c3label.text = "C4";
            c3Text.color = C4.color;
            c4label.text = "C3";
            c4Text.color = C3.color;
            c5label.text = "T7";
            c5Text.color = T7.color;
            c6label.text = "T8";
            c6Text.color = T8.color;
            c7label.text = "O1";
            c7Text.color = O1.color;
            c8label.text = "O2";
            c8Text.color = O2.color;

            tF7.isOn = true;
            tF8.isOn = true;
            tTP7.isOn = true;
            tTP8.isOn = true;
            tFp1.isOn = true;
            tFp2.isOn = true;
            tF3.isOn = true;
            tF4.isOn = true;
            tFz.isOn = true;
            tFc4.isOn = true;
            tFc3.isOn = true;
            tFcz.isOn = true;
            tFt7.isOn = true;
            tFt8.isOn = true;
            tC4.isOn = true;
            tC3.isOn = true;
            tCz.isOn = true;
            tT7.isOn = true;
            tT8.isOn = true;
            tCp4.isOn = true;
            tCp3.isOn = true;
            tCpz.isOn = true;
            tP4.isOn = true;
            tP3.isOn = true;
            tPz.isOn = true;
            tP7.isOn = true;
            tP8.isOn = true;
            tO1.isOn = true;
            tOz.isOn = true;
            tO2.isOn = true;

            tF7.enabled = false;
            tF8.enabled = false;
            tTP7.enabled = false;
            tTP8.enabled = false;
            tFp1.enabled = true;
            tFp2.enabled = true;
            tF3.enabled = false;
            tF4.enabled = false;
            tFz.enabled = false;
            tFc4.enabled = false;
            tFc3.enabled = false;
            tFcz.enabled = false;
            tFt7.enabled = false;
            tFt8.enabled = false;
            tC4.enabled = true;
            tC3.enabled = true;
            tCz.enabled = false;
            tT7.enabled = true;
            tT8.enabled = true;
            tCp4.enabled = false;
            tCp3.enabled = false;
            tCpz.enabled = false;
            tP4.enabled = false;
            tP3.enabled = false;
            tPz.enabled = false;
            tP7.enabled = false;
            tP8.enabled = false;
            tO1.enabled = true;
            tOz.enabled = false;
            tO2.enabled = true;
        }

        else if (number == 32)
        {
            currChnalleSize = number;
            F7.color = Color.red;
            F7.enabled = true;
            BF7.color = Color.red;
            BF7.enabled = true;
            F8.color = Color.red;
            F8.enabled = true;
            BF8.color = Color.red;
            BF8.enabled = true;
            TP7.color = Color.red;
            TP7.enabled = true;
            BTP7.color = Color.red;
            BTP7.enabled = true;
            TP8.color = Color.red;
            TP8.enabled = true;
            BTP8.color = Color.red;
            BTP8.enabled = true;
            Fp1.color = Color.red;
            Fp1.enabled = true;
            Fp2.color = Color.red;
            Fp2.enabled = true;
            BFp1.color = Color.red;
            BFp1.enabled = true;
            BFp2.color = Color.red;
            BFp2.enabled = true;

            F3.color = Color.red;
            F3.enabled = true;
            BF3.color = Color.red;
            BF3.enabled = true;
            F4.color = Color.red;
            F4.enabled = true;
            BF4.color = Color.red;
            BF4.enabled = true;
            Fz.color = Color.red;
            Fz.enabled = true;
            BFz.color = Color.red;
            BFz.enabled = true;
            Fc4.color = Color.red;
            Fc4.enabled = true;
            BFc4.color = Color.red;
            BFc4.enabled = true;
            Fc3.color = Color.red;
            Fc3.enabled = true;
            BFc3.color = Color.red;
            BFc3.enabled = true;
            Fcz.color = Color.red;
            Fcz.enabled = true;
            BFcz.color = Color.red;
            BFcz.enabled = true;

            Ft7.color = Color.red;
            Ft7.enabled = true;
            BFt7.color = Color.red;
            BFt7.enabled = true;
            Ft8.color = Color.red;
            Ft8.enabled = true;
            BFt8.color = Color.red;
            BFt8.enabled = true;
            C4.color = Color.red;
            C4.enabled = true;
            BC4.color = Color.red;
            BC4.enabled = true;
            C3.color = Color.red;
            C3.enabled = true;
            BC3.color = Color.red;
            BC3.enabled = true;
            Cz.color = Color.red;
            Cz.enabled = true;
            BCz.color = Color.red;
            BCz.enabled = true;
            T7.color = Color.red;
            T7.enabled = true;
            BT7.color = Color.red;
            BT7.enabled = true;

            T8.color = Color.red;
            T8.enabled = true;
            BT8.color = Color.red;
            BT8.enabled = true;
            Cp4.color = Color.red;
            Cp4.enabled = true;
            BCp4.color = Color.red;
            BCp4.enabled = true;
            Cp3.color = Color.red;
            Cp3.enabled = true;
            BCp3.color = Color.red;
            BCp3.enabled = true;
            Cpz.color = Color.red;
            Cpz.enabled = true;
            BCpz.color = Color.red;
            BCpz.enabled = true;
            P4.color = Color.red;
            P4.enabled = true;
            BP4.color = Color.red;
            BP4.enabled = true;
            P3.color = Color.red;
            P3.enabled = true;
            BP3.color = Color.red;
            BP3.enabled = true;

            Pz.color = Color.red;
            Pz.enabled = true;
            BPz.color = Color.red;
            BPz.enabled = true;
            P7.color = Color.red;
            P7.enabled = true;
            BP7.color = Color.red;
            BP7.enabled = true;
            P8.color = Color.red;
            P8.enabled = true;
            BP8.color = Color.red;
            BP8.enabled = true;
            O1.color = Color.red;
            O1.enabled = true;
            BO1.color = Color.red;
            BO1.enabled = true;
            Oz.color = Color.red;
            Oz.enabled = true;
            BOz.color = Color.red;
            BOz.enabled = true;
            O2.color = Color.red;
            O2.enabled = true;
            BO2.color = Color.red;
            BO2.enabled = true;

            c1label.text = "Fp1";
            c1Text.color = Fp1.color;
            c2label.text = "Fp2";
            c2Text.color = Fp2.color;
            c3label.text = "C4";
            c3Text.color = C4.color;
            c4label.text = "C3";
            c4Text.color = C3.color;
            c5label.text = "T7";
            c5Text.color = T7.color;
            c6label.text = "T8";
            c6Text.color = T8.color;
            c7label.text = "O1";
            c7Text.color = O1.color;
            c8label.text = "O2";
            c8Text.color = O2.color;

            tF7.isOn = true;
            tF8.isOn = true;
            tTP7.isOn = true;
            tTP8.isOn = true;
            tFp1.isOn = true;
            tFp2.isOn = true;
            tF3.isOn = true;
            tF4.isOn = true;
            tFz.isOn = true;
            tFc4.isOn = true;
            tFc3.isOn = true;
            tFcz.isOn = true;
            tFt7.isOn = true;
            tFt8.isOn = true;
            tC4.isOn = true;
            tC3.isOn = true;
            tCz.isOn = true;
            tT7.isOn = true;
            tT8.isOn = true;
            tCp4.isOn = true;
            tCp3.isOn = true;
            tCpz.isOn = true;
            tP4.isOn = true;
            tP3.isOn = true;
            tPz.isOn = true;
            tP7.isOn = true;
            tP8.isOn = true;
            tO1.isOn = true;
            tOz.isOn = true;
            tO2.isOn = true;

            tF7.enabled = true;
            tF8.enabled = true;
            tTP7.enabled = true;
            tTP8.enabled = true;
            tFp1.enabled = true;
            tFp2.enabled = true;
            tF3.enabled = true;
            tF4.enabled = true;
            tFz.enabled = true;
            tFc4.enabled = true;
            tFc3.enabled = true;
            tFcz.enabled = true;
            tFt7.enabled = true;
            tFt8.enabled = true;
            tC4.enabled = true;
            tC3.enabled = true;
            tCz.enabled = true;
            tT7.enabled = true;
            tT8.enabled = true;
            tCp4.enabled = true;
            tCp3.enabled = true;
            tCpz.enabled = true;
            tP4.enabled = true;
            tP3.enabled = true;
            tPz.enabled = true;
            tP7.enabled = true;
            tP8.enabled = true;
            tO1.enabled = true;
            tOz.enabled = true;
            tO2.enabled = true;
        }
        //A2.color = Color.red;
        A2.enabled = true;
        //BA2.color = Color.red;
        BA2.enabled = true;
        //A1.color = Color.red;
        A1.enabled = true;
        //BA1.color = Color.red;
        BA1.enabled = true;
    }

    public void ToggleChannel(string name)
    {
        if(name == "F7")
        {
            F7.enabled = !F7.enabled;
            BF7.enabled = !BF7.enabled;
        }
        if (name == "F8")
        {
            F8.enabled = !F8.enabled;
            BF8.enabled = !BF8.enabled;
        }
        if (name == "TP7")
        {
            TP7.enabled = !TP7.enabled;
            BTP7.enabled = !BTP7.enabled;
        }
        if (name == "TP8")
        {
            TP8.enabled = !TP8.enabled;
            BTP8.enabled = !BTP8.enabled;
        }
        if (name == "Fp1")
        {
            Fp1.enabled = !Fp1.enabled;
            BFp1.enabled = !BFp1.enabled;
        }
        if (name == "Fp2")
        {
            Fp2.enabled = !Fp2.enabled;
            BFp2.enabled = !BFp2.enabled;
        }
        if (name == "F3")
        {
            F3.enabled = !F3.enabled;
            BF3.enabled = !BF3.enabled;
        }
        if (name == "F4")
        {
            F4.enabled = !F4.enabled;
            BF4.enabled = !BF4.enabled;
        }
        if (name == "Fz")
        {
            Fz.enabled = !Fz.enabled;
            BFz.enabled = !BFz.enabled;
        }
        if (name == "Fc4")
        {
            Fc4.enabled = !Fc4.enabled;
            BFc4.enabled = !BFc4.enabled;
        }
        if (name == "Fc3")
        {
            Fc3.enabled = !Fc3.enabled;
            BFc3.enabled = !BFc3.enabled;
        }
        if (name == "Fcz")
        {
            Fcz.enabled = !Fcz.enabled;
            BFcz.enabled = !BFcz.enabled;
        }
        if (name == "Ft7")
        {
            Ft7.enabled = !Ft7.enabled;
            BFt7.enabled = !BFt7.enabled;
        }
        if (name == "Ft8")
        {
            Ft8.enabled = !Ft8.enabled;
            BFt8.enabled = !BFt8.enabled;
        }
        if (name == "C4")
        {
            C4.enabled = !C4.enabled;
            BC4.enabled = !BC4.enabled;
        }
        if (name == "C3")
        {
            C3.enabled = !C3.enabled;
            BC3.enabled = !BC3.enabled;
        }
        if (name == "Cz")
        {
            Cz.enabled = !Cz.enabled;
            BCz.enabled = !BCz.enabled;
        }
        if (name == "T7")
        {
            T7.enabled = !T7.enabled;
            BT7.enabled = !BT7.enabled;
        }
        if (name == "T8")
        {
            T8.enabled = !T8.enabled;
            BT8.enabled = !BT8.enabled;
        }
        if (name == "Cp4")
        {
            Cp4.enabled = !Cp4.enabled;
            BCp4.enabled = !BCp4.enabled;
        }
        if (name == "Cp3")
        {
            Cp3.enabled = !Cp3.enabled;
            BCp3.enabled = !BCp3.enabled;
        }
        if (name == "Cpz")
        {
            Cpz.enabled = !Cpz.enabled;
            BCpz.enabled = !BCpz.enabled;
        }
        if (name == "P4")
        {
            P4.enabled = !P4.enabled;
            BP4.enabled = !BP4.enabled;
        }
        if (name == "P3")
        {
            P3.enabled = !P3.enabled;
            BP3.enabled = !BP3.enabled;
        }
        if (name == "Pz")
        {
            Pz.enabled = !Pz.enabled;
            BPz.enabled = !BPz.enabled;
        }
        if (name == "P7")
        {
            P7.enabled = !P7.enabled;
            BP7.enabled = !BP7.enabled;
        }
        if (name == "P8")
        {
            P8.enabled = !P8.enabled;
            BP8.enabled = !BP8.enabled;
        }
        if (name == "O1")
        {
            O1.enabled = !O1.enabled;
            BO1.enabled = !BO1.enabled;
        }
        if (name == "Oz")
        {
            Oz.enabled = !Oz.enabled;
            BOz.enabled = !BOz.enabled;
        }
        if (name == "O2")
        {
            O2.enabled = !O2.enabled;
            BO2.enabled = !BO2.enabled;
        }
    }
}

