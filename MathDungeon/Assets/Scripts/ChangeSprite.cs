using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSprite : MonoBehaviour
{
    public GamePlay gp;
    public Sprite[] spriteArry;
    public int sprite = 0;
  

    public void MonsterAtk(){
        sprite =+ 1;
        GetComponent<SpriteRenderer>().sprite = spriteArry[sprite];
        sprite -= 1;
    }

    public void Monsteridle(){
        GetComponent<SpriteRenderer>().sprite = spriteArry[sprite];
    }
}
