using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffectPlayer : MonoBehaviour
{
    public AudioSource src, src2;
    public AudioClip PlayerDamageSfx, sfx2, sfx3;

    public void DamageDealthSfx()
    {
        src.clip = PlayerDamageSfx;
        src.Play();
    }

    public void DamageInflictSfx(){
        src.clip = sfx2;
        src2.clip = sfx3;
        src.Play();
        src2.Play();
    }

}
