using System.Threading;
using System.Globalization;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GamePlay : MonoBehaviour
{
    public string num, usernum, tempnum;
    public string[] ops = {"+","x"};   
    public Text UserInput, num1,num2,op;
    public string rum1;
    public string rum2;
    public int oprand, rand1, rand2;

    public void Start() {
        oprand = Random.Range(0,2);
        rand1 = Random.Range(1,11);
        rand2 = Random.Range(1,11);
        rum1 = rand1.ToString();
        rum2 = rand2.ToString();
        num1.text = rum1;
        num2.text = rum2;
        op.text = ops[oprand];
    }
    
    public void Update()
    {   
        if(num.Length<= 3){
            tempnum = num;  
            usernum = num;
        } 
        UserInput.text = usernum;
    }

    public void ButtonClear(){
        num = "";
        tempnum = "";
        usernum = "";
    }
    public void Button1(){
        num = tempnum+"1";
    }
    public void Button2(){
        num = tempnum+"2";
    }
    public void Button3(){
        num = tempnum+"3";
    }
     public void Button4(){
        num = tempnum+"4";
    }
     public void Button5(){
        num = tempnum+"5";
    }
     public void Button6(){
        num = tempnum+"6";
    }
    public void Button7(){
        num = tempnum+"7";
    }
    public void Button8(){
        num = tempnum+"8";
    }
    public void Button9(){
        num = tempnum+"9";
    }
    public void Button0(){
        num = tempnum+"0";
    }

  
}
