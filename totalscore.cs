using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class totalscore : MonoBehaviour
{
    public Text finalScore;
    public static int value = 0;

    // Start is called before the first frame update
    void Start()
    {
        finalScore = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        finalScore.text = value.ToString(); 

        //if(finalScore.text == "7")
        //{
        //  SceneManager.LoadScene("Quiz Sucess");
        // }
        // }


    }
}