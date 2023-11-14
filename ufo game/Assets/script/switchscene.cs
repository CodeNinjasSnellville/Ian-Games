using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class switchscene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void SwitchScenes()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("0");
    }
}
