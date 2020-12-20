using Proyecto26;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;
using TMPro;
using System.Linq;

public class DataBase_base : MonoBehaviour
{
    public static adminData loggedInAdmin;
    public static Database_register_child registeredChildData;
    public static Database_register_child loggedInStudent;
    public static string password;
    public static string username;
    public static string email;
    public GameObject input_field;
    public GameObject input_field2;
    /// <summary>
    /// //////////////////////
    /// </summary>

    public GameObject EE;
    public GameObject PP2;
    public GameObject PP;
    public GameObject UU;
    public GameObject registerpanel;
    public GameObject invalid;
    public GameObject invalid2;
    public GameObject invalid3;
    public GameObject loginpanel;

    public GameObject uname;
    void Start() 
    {
        loggedInAdmin = databaseadmin.loggedInAdmin;
    }
    public void Take_input()
    {
        /* ALI HASSAN & MUSTAFA DAR
             * This method is used in admin login 
             * RestClient's get method is used to retrieve data from the database based on username input
             * reponse is stored in ra variable which is an object of Database_register1
             * Database_register1 contains information about admin credentials 
             * This method is called when Sign in button is clicked
        */
        if (input_field.GetComponent<InputField>().text != "" || input_field.GetComponent<InputField>().text != null && input_field.GetComponent<InputField>().text != "" || input_field2.GetComponent<InputField>().text != null)
        {
            username = input_field.GetComponent<InputField>().text;
            RestClient.Get<Database_register_child>(url: "https://fypdb-62d0f-default-rtdb.firebaseio.com/" + loggedInAdmin.username +"/students/"+username 
                + ".json").Then(onResolved: response =>
                {
                    //DataBase_base.loggedInAdmin = response;
                    //databaseDelete.loggedInAdmin = response;
                    if (response.password == input_field2.GetComponent<InputField>().text)
                    {
                        username = response.username;
                        email = response.email;
                        password = response.password;
                        loggedInStudent = response;
                        Debug.Log("Logged in student data is:");
                        Debug.Log(loggedInAdmin.username);
                        Debug.Log(loggedInAdmin.password);
                        Debug.Log(loggedInAdmin.email);
                        Debug.Log("signin successful!");
                        SceneManager.LoadScene("menu");
                    }
                    else
                    {
                        invalid3.SetActive(true);
                    }
                });
        }
        else
        {
            invalid3.SetActive(true);
            Debug.Log("Wrong username/password");
        }


    }
    IEnumerator ExampleCoroutine()
    {
        Debug.Log("password matched");
        yield return new WaitForSeconds(1);
        Debug.Log("Its Sucessfully Ready");


    }
    public void OnCancel()
    {
        CancelInvoke();
    }

    public void Az(Database_register_child student)
    {
        RestClient.Put("https://fypdb-62d0f-default-rtdb.firebaseio.com/" + loggedInAdmin.username + "/" + "students/" + registeredChildData.username + ".json", registeredChildData);
    }

    public void addRegsiter()
    {
        if ((UU.GetComponent<InputField>().text != "" && UU.GetComponent<InputField>().text != null) &&
            (PP.GetComponent<InputField>().text != "" && PP.GetComponent<InputField>().text != null) &&
            (EE.GetComponent<InputField>().text != "" && EE.GetComponent<InputField>().text != null) &&
            (PP.GetComponent<InputField>().text == PP2.GetComponent<InputField>().text))
        {

            username = UU.GetComponent<InputField>().text;
            email = EE.GetComponent<InputField>().text;
            password = PP.GetComponent<InputField>().text;
            registeredChildData = new Database_register_child();

            Az(registeredChildData);
            /*
             * register panel is set inactive after successful data inputs
            */
            registerpanel.SetActive(false);
            //AccountSuccess.SetActive(true);
            Debug.Log("registration successful");

        }
        else
        {
            if (PP.GetComponent<InputField>().text != PP2.GetComponent<InputField>().text)
            {

                registerpanel.SetActive(true);
                //loginpanel.SetActive(false);
                Debug.Log("password mismatch");

                invalid2.SetActive(true);
            }

            registerpanel.SetActive(true);
            //loginpanel.SetActive(false);
            Debug.Log("Enter something");

            invalid.SetActive(true);
        }

    }

   
}
    

  
    

    






