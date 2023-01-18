using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CalcScript : MonoBehaviour
{
    public Toggle USdollars;
    public Toggle JapaneseYen;
    public Toggle ChinaYuan;
    public Toggle HongKongDollar;

    public Text value;

    private string input;
    public double inputv;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        value.text = "$ " + inputv;
    }

    public void ReadStringInput(string s)
    {
        input = s;

        double.TryParse(input, out inputv);
    }

    public void convertBtn()
    {
        if (USdollars.isOn)
        {
            inputv *= 0.74f;
        }

        if (JapaneseYen.isOn)
        {
            inputv *= 82.78f;
        }
        if (HongKongDollar.isOn)
        {
            inputv = 5.92f;
        }
        if (ChinaYuan.isOn)
        {
            inputv = 5.12f;
        }
        HongKongDollar.isOn = false;
        ChinaYuan.isOn = false;

        value.text = "$ " + inputv;
    }

    public void clearBtn(InputField s)
    {
        s.text = "" + 0;
        value.text = "" + s;

        USdollars.isOn = false;
        JapaneseYen.isOn = false;
    }
}
