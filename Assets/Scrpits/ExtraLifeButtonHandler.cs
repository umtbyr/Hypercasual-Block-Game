using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExtraLifeButtonHandler : MonoBehaviour
{

    public static int extraLifeCost = 10;
    private int TotalPoint;
    Text TotalPointBoxText;
    void Start()
    {
        TotalPoint = PlayerMovoment.TotalPoint;
        Text usegoldbuttontext = transform.GetChild(0).gameObject.GetComponent<Text>();
        Text priceText = transform.GetChild(1).gameObject.GetComponent<Text>();
         TotalPointBoxText = transform.GetChild(2).gameObject.GetComponent<Text>();

        priceText.text = $"-{extraLifeCost}";
        TotalPointBoxText.text = TotalPoint.ToString();

    }

    // Update is called once per frame
    void Update()
    {
        TotalPoint = PlayerMovoment.TotalPoint;
        TotalPointBoxText.text = TotalPoint.ToString();

    }
}
