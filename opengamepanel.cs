using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class opengamepanel : MonoBehaviour
{
    public void studentLogin() 
    {
        SceneManager.LoadScene("StudentSignin");
    }

   public void open()
    {
        SceneManager.LoadScene("Games sec");
    }
public void opencar()
    {
        SceneManager.LoadScene("Prototype 1");
    }
    public void blockgame()
    {
        SceneManager.LoadScene("Block game");
    }
    public void backbutton()
    {
        SceneManager.LoadScene("menu");

    }
    public void authentication()
    {
        SceneManager.LoadScene("Authentication");

    }
    public void studentAuthentication()
    {
        SceneManager.LoadScene("StudentAuthentication");

    }
    public void learningmenu()
    {
        SceneManager.LoadScene("menu 1");


    }
    public void learningvideo()
    {
        SceneManager.LoadScene("Playvideo");

    }
    public void learningvideo1()
    {
        SceneManager.LoadScene("Playvideo 1");

    }
    public void adminportal()
    {
        SceneManager.LoadScene("AdminPortal");

    }

    public void adminpage()
    {
        SceneManager.LoadScene("adminpage");

    }
    public void quizpage()
    {
        SceneManager.LoadScene("StarterScene");

    }
    public void quizmenu()
    {
        SceneManager.LoadScene("StarterScene");

    }
    public void quiz()
    {
        SceneManager.LoadScene("quiz bar");

    }
    public void studentLogOutButton() 
    {
        SceneManager.LoadScene("adminpage");
    }
}








