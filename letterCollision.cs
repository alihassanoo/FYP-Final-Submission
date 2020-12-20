using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class letterCollision : MonoBehaviour
{
    public Text t;
    public Text HighScore;
    SpriteRenderer letter;
    private String[] letters = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
    int i = 0;
    int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        HighScore.text = PlayerPrefs.GetInt("HighScore",0).ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        SpriteRenderer let = other.GetComponent<SpriteRenderer>();
        string letter = other.name.Substring(0, 1);
        Debug.Log(i);
        Debug.Log(letters[i]);
        Debug.Log(other.name);

      


        if (letters[i] == other.name.Substring(0, 1))
        {
            score += 10;
            string s = score.ToString();
            t.text = s;//changed into tostring
            Destroy(let);
            i++;

            PlayerPrefs.SetInt("HighScore", score);

            if (score > PlayerPrefs.GetInt("HighScore", 0))
            {
                PlayerPrefs.SetInt("HighScore", score);
                HighScore.text = score.ToString();

            }


            //  highscore();
        }
        else
        {
            score -= 10;
            string s = score.ToString();
            t.text = s;
            Destroy(let);
            i++;


            PlayerPrefs.SetInt("HighScore", score);

            if (score > PlayerPrefs.GetInt("HighScore", 0))
            {
                PlayerPrefs.SetInt("HighScore", score);
                HighScore.text = score.ToString();

            }
            //    highscore();


            //SceneManager.LoadScene("EndScreen");



        }
    }
    void Update()
    {
        if (score < 0)
        {
            //  Debug.Log("end");
            SceneManager.LoadScene("EndScreen");
        }
    }

   public void highscore()
    {
        PlayerPrefs.SetInt("HighScore", score);

        if(score >  PlayerPrefs.GetInt("HighScore",0))
        {
            PlayerPrefs.SetInt("HighScore", score);
            HighScore.text = score.ToString();

        }
    }


    //letter = other.GetComponent<SpriteRenderer>();
    //Debug.Log(other.name);

    //int a = Int32.Parse(t1.text.ToString());
    //a++;
    //t1.text = a.ToString();



}

