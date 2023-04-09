using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;

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

    public void Monsteridle(/*float duration*/){
       
        GetComponent<SpriteRenderer>().sprite = spriteArry[sprite];
        sprite =+1;
        //await Task.Delay((int)duration*500);   
        
        GetComponent<SpriteRenderer>().sprite = spriteArry[sprite];
        sprite =+1;
        //await Task.Delay((int)duration*500); 
        GetComponent<SpriteRenderer>().sprite = spriteArry[sprite];
         sprite -=2;
        GetComponent<SpriteRenderer>().sprite = spriteArry[sprite]; 
        //await Task.Delay((int)duration*500);   
        
    }

    
}
