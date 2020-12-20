using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManage : MonoBehaviour
{
    // private string leveltoload;

    public static int increment = 0;
    public static int score = 0;
    public Question[] questions;
    private static List<Question> unansweredQ;
    private Question currentQ;
   

    [SerializeField]
    public Image pic;
   
    [SerializeField]
    private Text facetext;
   

    [SerializeField]
    private float timebetweenques = 1f;


    void Start()
    {
        if (unansweredQ == null || unansweredQ.Count == 0)
        {
            unansweredQ = questions.ToList<Question>();
           // increment += 1;
            Debug.Log(unansweredQ);
            //Gameover();

        }
      



     

        GetRandomQuestion();
 
    }

    void Gameover()
    {
        if (increment >= 10)
        {
            //basically  its quiz over scene
            SceneManager.LoadScene("Game Over");
        

        }
     
    }



    void GetRandomQuestion()
    {
        //selecting a random ques
        int randomquesindex = Random.Range(0, unansweredQ.Count);
        currentQ = unansweredQ[randomquesindex];
       
        
        facetext.text = currentQ.fact;
        

        Debug.Log("testing image");

        pic.sprite = currentQ.image.sprite;

        Debug.Log(pic.name);

      
           
        //removing the question once answered from list
        unansweredQ.RemoveAt(randomquesindex);

        
    }

    IEnumerator TransitiontonextQues()
    {
        increment = increment + 1;
        //Debug.Log(increment);
        unansweredQ.Remove(currentQ);

       // increment = increment + 1;
        //Debug.Log(increment);
        //wait for sec to wait
        yield return new WaitForSeconds(timebetweenques);
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        //increment+=1;
        //Debug.Log(increment);
        Gameover();

    }

   public void UserselectTrue()
    {
        if (currentQ.isTrue)
        {
            Debug.Log("CORRECT");
            scoreadd.scorevalue += 10;
            //DataBase_base.loggedInAdmin = scoreadd;
            totalscore.value += 1;
            Debug.Log(totalscore.value);
            success();
          //  Destroy(image);

        }

        else
        {
            Debug.Log("WRONG");
           // scoreadd.scorevalue -= 10;
            //increment += 1;
            //Debug.Log(increment);
        }

        StartCoroutine(TransitiontonextQues());
    }
    
    

 /*   public void OnCollisionEnter(Collision collision)
    {
        Debug.Log("It is colliding");
        if (!currentQ.isTrue)
        {
            Debug.Log("CORRECT");
            scoreadd.scorevalue += 10;
            totalscore.value += 1;
            success();

            // increment+=1;
            //Debug.Log(increment);
        }

        else
        {
            Debug.Log("WRONG");
            scoreadd.scorevalue -= 10;
             increment += 1;
             Debug.Log(increment);
        }
        //success();
        StartCoroutine(TransitiontonextQues());

    }
    */

   public void UserselectFalse()
    {
        if (!currentQ.isTrue)
        {
            Debug.Log("CORRECT");
            //scoreadd.scorevalue += 10;
            totalscore.value += 1;
            success();
           // increment+=1;
            //Debug.Log(increment);
        }

        else
        {
            Debug.Log("WRONG");
           // scoreadd.scorevalue -= 10;
           // increment += 1;
           // Debug.Log(increment);
        }
        //success();
        StartCoroutine(TransitiontonextQues());
        
    }

    void success()
    {
        if(totalscore.value > 7)
        {
            SceneManager.LoadScene("quiz Success");
        }
    }




}

   
        //  timer -= Time.deltaTime;
        // timersec.text = timer.ToString("f2");
        // if (timer <= 0)
        // {
        //   StartCoroutine(TransitiontonextQues());
        // }
        //}
    
