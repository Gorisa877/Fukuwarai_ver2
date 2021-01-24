using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
 
 
public class SliderController: MonoBehaviour
{

    Slider Slider;
    public static float StartS = 5.0f;
    public Text StartText;

    // Use this for initialization
    void Start()
    {

        Slider = GetComponent<Slider>();
        int max = 10;
        int now = 5;
        int min = 0;

        //スライダーの最大値の設定
        Slider.maxValue = max;
        //スライダーの現在値の設定
        Slider.value = now;
        //スライダーの最小値の設定
        Slider.minValue = min;
        print(Slider.value);

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Method()
    {       
        StartS = Slider.value;
        StartText.text = StartS.ToString();
    }


}