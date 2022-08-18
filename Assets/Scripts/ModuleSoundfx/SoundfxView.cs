using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Agate.MVC.Base;

namespace ShooterSpace.Module.Soundfx
{
    public class SoundfxView : BaseView
    {
        [SerializeField]
        AudioSource soundfxShoot;
        [SerializeField]
        AudioSource soundBGM;

        AudioClip soundfxClip;
        AudioClip soundBGMClip;

        public void PlaySFX()
        {
            soundfxClip = Resources.Load<AudioClip>("Sounds/Sfx_Shoot");
            soundfxShoot.PlayOneShot(soundfxClip);
            Debug.Log("Play SFX");
        }
        public void PlayBGM()
        {
            soundBGMClip = Resources.Load<AudioClip>("Sounds/Bgm_Sound");
            soundBGM.clip = soundBGMClip;
            soundBGM.Play();
            Debug.Log("Play BGM");
        }
    }
}
