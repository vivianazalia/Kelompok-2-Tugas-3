using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Agate.MVC.Base;
using Agate.MVC.Core;
using ShooterSpace.Module.PubSubMessage;

namespace ShooterSpace.Module.Soundfx
{
    public class SoundfxController : ObjectController<SoundfxController, SoundfxView>
    {

        public void PlaySounds(PlaySoundMessage message)
        {
            if (message.audioIndex == 1)
                _view.PlaySFX();
            else if (message.audioIndex == 2)
                _view.PlayBGM();
        }

    }
}
