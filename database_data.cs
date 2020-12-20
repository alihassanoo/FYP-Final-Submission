using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class database_data 
{
    
    public string login_code;
/*    public float Playtime;
    public int Score_quiz_right;
    public int Score_quiz_wrong;
    public float Score_quiz_ratio;
    public int Score_game;*/

 
    //public string name;
    public database_data()
    {
        login_code = DataBase_base.password;
        /*Score_quiz_right = DataBase_base.score;
        Score_quiz_wrong = DataBase_base.Wscore;
        Score_quiz_ratio = DataBase_base.ratio_b;// / Score_quiz_wrong;
        Score_game = DataBase_base.gscore;
        Playtime = DataBase_base.playedTime;*/


       // name = DataBase_base.username;
    }

}
