using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keypad : MonoBehaviour
{
    public GamePlay gp;

    public void Update(){
        gp.UserInput.text = gp.usernum;
    }

    public void ButtonEnter(){
        if (gp.ans == int.Parse(gp.usernum)){
            //gp.mobval -= gp.ans;
        } 
        else{
            gp.TakeDamage();
        }
        ButtonRefresh();
        
    }

    public void ButtonRefresh(){
        ButtonClear();
        gp.randomizer();
        
    }
    public void ButtonClear(){
        gp.num = "";
        gp.tempnum = "";
        gp.usernum = "";
    }
    public void Button1(){
        gp.num = gp.tempnum+"1";
    }
    public void Button2(){
        gp.num = gp.tempnum+"2";
    }
    public void Button3(){
        gp.num = gp.tempnum+"3";
    }
     public void Button4(){
        gp.num = gp.tempnum+"4";
    }
     public void Button5(){
        gp.num = gp.tempnum+"5";
    }
     public void Button6(){
        gp.num = gp.tempnum+"6";
    }
    public void Button7(){
        gp.num = gp.tempnum+"7";
    }
    public void Button8(){
        gp.num = gp.tempnum+"8";
    }
    public void Button9(){
        gp.num = gp.tempnum+"9";
    }
    public void Button0(){
        gp.num = gp.tempnum+"0";
    }

  
}


