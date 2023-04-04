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
    public Text UserInput, num1 ,num2, op, playerValue, monsterValue;
    
    public int oprand, rand1, rand2, rum1, rum2, ans;
    public int maxHealth = 100;
    public int currentHealth;

    public HealthBarScript healthBar;
    public void Start() {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        playerValue.text = currentHealth.ToString();
        //monsterValue.text = mobval.ToString();
        randomizer();
    }
    public void randomizer(){
        rand1 = Random.Range(1,11);
        oprand = Random.Range(0,2);
        rand2 = Random.Range(1,11);
        rum1 = rand1;
        rum2 = rand2;
        num1.text = rum1.ToString();
        num2.text = rum2.ToString();
        op.text = ops[oprand];
        switch(oprand)
        {
            case 0:
                ans = rand1+rand2;
                break;
            case 1:
                ans = rand1*rand2;  
                break;  
        }
    }

    public void TakeDamage(){
        currentHealth -= ans;
        healthBar.setHealth(currentHealth);
        playerValue.text = currentHealth.ToString();
    }
    
    public void Update()
    {   
        if(num.Length<= 3){
            tempnum = num;  
            usernum = num;
        } 
   
    }


}