using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreTextMainMenu : MonoBehaviour
{
    private int score;

    // Start is called before the first frame update
    void Start()
    {
        score = PlayerPrefs.GetInt("TotalPoint");
    }

    // Update is called once per frame
    void Update()
    {
        if (score != 0)
            gameObject.GetComponent<TMP_Text>().text = score.ToString();
        else
        {

            gameObject.GetComponent<TMP_Text>().text = "";
        }
    }
}
