using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class MonsterAnimation : MonoBehaviour
{
    public GamePlay gp;
    public Animator Animator;
    // Start is called before the first frame update
    void Start()
    {
        Animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gp.currentPlayerHealth > 0)
        {
            if (Animator != null)
            {

                if (gp.damage == true)
                {
                    Wait(1);
                }
                gp.damage = false;

            }
        } 
        else {
            gp.damage = false;
        }


    }

    public async void Wait(float duration)
    {

        Animator.SetBool("Attack", true);
        Animator.SetBool("idle", false);
        await Task.Delay((int)duration * 800);
        Animator.SetBool("Attack", false);
        Animator.SetBool("idle", true);
        await Task.Delay((int)duration * 500);
    }


}
