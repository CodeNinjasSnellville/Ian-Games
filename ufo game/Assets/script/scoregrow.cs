using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoregrow : MonoBehaviour
{
    public Text score;

    public GameObject player;

    public int scroenum = 0;
    public int scroenum2 = 0;
    public int scroenum3 = 0;

    private float timer = 0.0f;
    private float waittime = 1.0f;


    void Start()
    {
        score.text = "score: 0";
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if(timer > waittime)
        {
            scroenum++;
            score.text = "score:" + scroenum3 + ":" + scroenum2 + ":" + scroenum;
            timer = timer - waittime;

            if(scroenum >= 60)
            {
                scroenum = scroenum - 60;
                scroenum2++;
                if (scroenum2 >= 60)
                {
                    scroenum2 = scroenum2 - 60;
                    scroenum3++;
                }
            }

        }
    }
}
