using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerHud : MonoBehaviour
{
    public float counterTime;
    public Text counterText;
    private bool gameRun = false;

    // Start is called before the first frame update
    void Start()
    {
        gameRun = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameRun)
        {
            counterTime += Time.deltaTime;
            counterText.text = "Time: " + Mathf.Round(counterTime).ToString();
        }
    }
}
