using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hit_detect : MonoBehaviour
{
    private GameManage script;
    public GameObject x;
    
    // Start is called before the first frame update
    void Start()
    {
        script = gameObject.GetComponent<GameManage>();
     
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    private void OnTriggerEnter(Collider other)
    {
        //gameObject.GetComponent<GameManage>().UserselectTrue();
      
        Debug.Log("in collider");

        if (other.gameObject.name == "yes")
        {
            Debug.Log("in yes");
            x.GetComponent<GameManage>().UserselectTrue();
            //script.UserselectTrue();
          
        }
        else
        {
            Debug.Log("in No");
            x.GetComponent<GameManage>().UserselectFalse();
            //script.UserselectFalse();
        }

        // gameObject.GetComponent<GameManage>().UserselectTrue();

        //  scoreadd.scorevalue += 10;
        // totalscore.value += 1;
    }



}
