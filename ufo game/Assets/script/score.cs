using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class thescore : MonoBehaviour
{
public Text scored;
public int thescire = 0;

    void Awake()
    {
        StartCoroutine(Loop());
    }
    void Start()
    {
        scored.text = "time : 0";
    }

    // Update is called once per frame
    void Update()
    {

        scored.text = "time : " + thescire;

    }

    IEnumerator Loop()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            thescire += 1;

        }
    }
}

