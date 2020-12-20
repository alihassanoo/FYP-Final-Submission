using System.Collections;
using System.Collections.Generic;
using Proyecto26;
using UnityEngine;
using UnityEngine.UI;

public class databaseDelete : MonoBehaviour
{

    public GameObject uname;
    public static adminData loggedInAdmin = new adminData();
    public Database_register_child student = new Database_register_child();


    adminData ra = new adminData();
    DataBase_base a;

    

    public void DeleteUser() {

        name = uname.GetComponent<InputField>().text;
        Debug.Log(name);
        RestClient.Get<Database_register_child>(url: "https://fypdb-62d0f-default-rtdb.firebaseio.com/" + student.username
                + "/.json").Then(onResolved: response =>
                {
                    Debug.Log(student.username);
                    Debug.Log(response.username);
                });
                         
        


        /*RestClient.Get<Database_register_child>(url: "https://fypdb-62d0f-default-rtdb.firebaseio.com/" + name
                + "/.json").Then(onResolved: response =>
                {
                    Debug.Log("going into check");
                    ra = response;
                    // Debug.Log("going into check");
                    checkk();
                });
        /* RestClient.Get<adminData>(url: "https://fypdb-62d0f-default-rtdb.firebaseio.com/" + ra.username + "/students"
                           + "/.json").Then(onResolved: admin_response =>
                           {
                               Debug.Log(admin_response.username);
                               RestClient.Get<Database_register_child>(url: "https://fypdb-62d0f-default-rtdb.firebaseio.com/" + ra.username + "/students" + name
                                 + "/.json").Then(onResolved: student_response =>
                                       {
                                           Database_register_child studentToDelete = student_response;
                                           Debug.Log(student_response.username);

                                       });
                           });*/



    }
    public void checkk()
    {
        Debug.Log("in check");
        if (ra.username == name)
        {
            ra.username = null;
            ra.password = null;
            ra.email = null;

        }
        else
        {
            Debug.Log("No such user");
        }
    }
}
    