using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSprite : MonoBehaviour
{
    public GamePlay gp;
    public Sprite sp1, sp2;
    private void Update()
    {
       /*if(gp.ans != int.Parse(gp.usernum)){
            MonsterAtk();
            
       }*/
    }

    public void MonsterAtk(){
        GetComponent<SpriteRenderer>().sprite = sp2;
    }

    public void Monsteridle(){
        GetComponent<SpriteRenderer>().sprite = sp1;
    }
}
