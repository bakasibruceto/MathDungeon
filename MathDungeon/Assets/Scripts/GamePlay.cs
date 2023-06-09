using System.Threading.Tasks;
using System.Threading;
using System.Globalization;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GamePlay : MonoBehaviour
{
    
    public Shake shake;
    public SoundEffectPlayer sfx;
    public ChangeSprite cs;
    public HealthBarScript healthBar;
    public Text UserInput, num1, num2, operation, playerValue, monsterValue;
    public string[] operators = { "+", "x" };
    public string num, usernum, tempnum;
    public int oprand, rand1, rand2, ans;
    public int maxPlayerHealth = 100, maxMonsterHealth = 100;
    public int currentPlayerHealth, currentMonsterHealth, plytemp;
    public SceneSwitcher scene;

    public bool clicked = false;
    public bool damage = false;


    public void Start()
    {
        currentPlayerHealth = maxPlayerHealth;
        currentMonsterHealth = maxMonsterHealth;
        healthBar.SetPlayerMaxHealth(maxPlayerHealth);
        healthBar.SetMonsterMaxHealth(maxMonsterHealth);
        playerValue.text = currentPlayerHealth.ToString();
        monsterValue.text = currentMonsterHealth.ToString();
        randomizer();
        
    }
    public void randomizer()
    {
        rand1 = Random.Range(1, 11);
        oprand = Random.Range(0, 2);
        rand2 = Random.Range(1, 11);
        num1.text = rand1.ToString();
        num2.text = rand2.ToString();
        operation.text = operators[oprand];
        switch (oprand)
        {
            case 0:
                ans = rand1 + rand2;
                break;
            case 1:
                ans = rand1 * rand2;
                break;
        }
    }
    public void TakeDamage()
    {
        damage = true;
        currentPlayerHealth -= ans;
        if (currentPlayerHealth <= 0)
        {
            SceneManager.LoadScene("GameOverState");
        }
        else
        {
            AnimationDelay(1);
        }
    }


    
    public async void AnimationDelay(float duration)
    { 
        await Task.Delay((int)duration*800);   
        sfx.DamageDealthSfx();
        healthBar.setPlayerHealth(currentPlayerHealth);
        playerValue.text = currentPlayerHealth.ToString();
    }


    public void MonsterTakeDamage()
    {
        currentMonsterHealth -= ans;
        if (currentMonsterHealth <= 0)
        {
            maxMonsterHealth += 100;
            currentMonsterHealth = maxMonsterHealth;
            healthBar.SetMonsterMaxHealth(maxMonsterHealth);
            healthBar.setMonsterHealth(maxMonsterHealth);
        }
        //Class from HealthBarScript Monster Health

        healthBar.setMonsterHealth(currentMonsterHealth);
        monsterValue.text = currentMonsterHealth.ToString();

        shake.Shake1();
        sfx.DamageInflictSfx();
    }
    void Update()
    {
        
        



        if (num.Length <= 3)
        {
            tempnum = num;
            usernum = num;
        }

    








    }
}