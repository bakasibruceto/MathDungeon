using System.Threading;
using System.Globalization;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GamePlay : MonoBehaviour
{   
    public string num, usernum, tempnum;
    public string[] ops = {"+","x"};   
    public Text UserInput, num1 ,num2, op, playerValue, monsterValue;
    public int oprand, rand1, rand2, ans;
    public int maxHealth = 100;
    public int currentHealth;
    public int maxMonsterHealth = 100;
    public int currentMonsterHealth;
    public HealthBarScript healthBar;
    public HealthBarScript MonsterBar;

    public SceneSwitcher scene;
     public void Start() {
        currentHealth = maxHealth;
        currentMonsterHealth = maxMonsterHealth;
        healthBar.SetMaxHealth(maxHealth);
        MonsterBar.SetMaxHealth(maxMonsterHealth);
        playerValue.text = currentHealth.ToString();
        monsterValue.text = currentMonsterHealth.ToString();
        randomizer();
    }
    public void randomizer(){
        rand1 = Random.Range(1,11);
        oprand = Random.Range(0,2);
        rand2 = Random.Range(1,11);
        num1.text = rand1.ToString();
        num2.text = rand2.ToString();
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
        if (currentHealth <= 0){
            SceneManager.LoadScene("GameOverState");
        } else {
            healthBar.setHealth(currentHealth);
            playerValue.text = currentHealth.ToString();
        }

       
    }

    public void MonsterTakeDamage(){

        currentMonsterHealth -= ans; 
        if (currentMonsterHealth <= 0){
            maxMonsterHealth += 100;
            currentMonsterHealth = maxMonsterHealth; 
            MonsterBar.SetMonsterMaxHealth(maxMonsterHealth);
            MonsterBar.SetMaxHealth(maxMonsterHealth);
        }
        //Class from HealthBarScript Monster Health
        MonsterBar.setMonsterHealth(currentMonsterHealth);
        monsterValue.text = currentMonsterHealth.ToString();
    }
    
    public void Update()
    {   
        if(num.Length<= 3){
            tempnum = num;  
            usernum = num;
        } 
   
    }


}