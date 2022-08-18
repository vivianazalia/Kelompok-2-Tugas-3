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
        AudioClip soundfxShootClip;
        [SerializeField]
        AudioSource soundBGM;

        
        public void PlaySFX()
        {
            soundfxShoot.PlayOneShot(soundfxShootClip);
        }
        public void PlayBGM()
        {
            soundBGM.Play();
        }

    }
}
