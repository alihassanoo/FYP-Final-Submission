using Proyecto26;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;
using TMPro;

public class databaseadmin : MonoBehaviour
{
    public static adminData registeredAdminData;
    public static adminData loggedInAdmin;
    public static string password;
    public static string username;
    public static string email;
    public GameObject input_field;
    public GameObject input_field2;
    public static int playedTime;
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
    public GameObject AccountSuccess;
    public GameObject loginpanel;

    void Start()
    {

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
            RestClient.Get<adminData>(url: "https://fypdb-62d0f-default-rtdb.firebaseio.com/" + username
                + ".json").Then(onResolved: response =>
                {
                    //DataBase_base.loggedInAdmin = response;
                    //databaseDelete.loggedInAdmin = response;
                    if (response.password == input_field2.GetComponent<InputField>().text)
                    {
                        username = response.username;
                        email = response.email;
                        password = response.password;
                        loggedInAdmin = response;
                        Debug.Log("Logged in admin data is:");
                        Debug.Log(loggedInAdmin.username);
                        Debug.Log(loggedInAdmin.password);
                        Debug.Log(loggedInAdmin.email);
                        Debug.Log("signin successful!");
                        SceneManager.LoadScene("adminpage");
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
        /* MUSTAFA DAR
         * This coroutine is used to wait some second if the login credentials are correct then load the next scene
         * Next Scene - adminpage
        */
        Debug.Log("password matched");
        yield return new WaitForSeconds(1);
        //load.SetActive(true);
        // if (remember_me)
        // {
        //   PlayerPrefs.SetInt("verify", 1);
        //}
        Debug.Log("Its Sucessfully Ready");
        /* Ali Hassan
         * Next scene called on successful login
        */
        

    }




    public void OnCancel()
    {
        CancelInvoke();
    }
    
    public void Az(adminData admin)
    {
     /* MUSTAFA
         * This method is used to put the data in the firebase realtime database 
         * Firebase uses json format to store data
         * Method takes 2 arguments
         * 1. Link to realtime database
         * 2. The object which is being put in the database
         * Object ra contains username, password, email of the admin
         * All these variables are being put in the database under the folder ra.username - username of the admin
         * This is the format
         * admin_username
             *          username
             *          email
             *          password
             *          students
    */
        RestClient.Put("https://fypdb-62d0f-default-rtdb.firebaseio.com/" + admin.username + ".json", admin);

    }

    public void addRegsiter()
    {
        /* ALI HASSAN & MUSTAFA DAR - this method is for registering an admin 
         * UU - Username field, 
         * PP - Password field,
         * EE - Email field
         * addRegister is triggered when SIGN UP button is clicked
         * -If condition-
         * checks if all the fields are not null and confirm password matches password: only then condition will fire
         */
        
        if ((UU.GetComponent<InputField>().text != "" && UU.GetComponent<InputField>().text != null) &&
            (PP.GetComponent<InputField>().text != "" && PP.GetComponent<InputField>().text != null) &&
            (EE.GetComponent<InputField>().text != "" && EE.GetComponent<InputField>().text != null) &&
            (PP.GetComponent<InputField>().text == PP2.GetComponent<InputField>().text))
        {
            /*
             * ra is data class which stores the data of admin which is then put in the firebase realtime database
            */
            username = UU.GetComponent<InputField>().text;
            email = EE.GetComponent<InputField>().text;
            password = PP.GetComponent<InputField>().text;
            registeredAdminData = new adminData();

            
            /* ALI HASSAN
             * Az method is called to put this data in the database
            */
            Az(registeredAdminData);
            /*
             * register panel is set inactive after successful data inputs
            */
            registerpanel.SetActive(false);
            AccountSuccess.SetActive(true);
            Debug.Log("registration successful");

        }
        /* MUSTAFA DAR
         * - Else - 
         * here it is checked if password matches confirm password
         * if not error is generated and admin account is not created
         * Az method is not called in else
         * Az method puts the data in the database
        */
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
