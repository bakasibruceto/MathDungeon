using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarScript : MonoBehaviour
{
    public Slider PlayerSlider, MonsterSlider;
    
    public void SetMaxHealth(int health)
    {
        PlayerSlider.maxValue = health;
        PlayerSlider.value = health;

    }
    public void setHealth(int health)
    {
        PlayerSlider.value = health;
        
    }

    public void setMonsterHealth(int health)
    {
         MonsterSlider.value = health;
    }

    public void SetMonsterMaxHealth(int health)
    {
        MonsterSlider.maxValue = health;
        MonsterSlider.value = health;
    }
}
