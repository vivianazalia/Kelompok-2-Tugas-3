using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Agate.MVC.Base;
using ShooterSpace.Module.PubSubMessage;

namespace ShooterSpace.Module.Soundfx
{
    public class SoundfxConnector : BaseConnector
    {
        SoundfxController _audio;
        protected override void Connect()
        {
            Subscribe<PlaySoundMessage>(_audio.PlaySounds);
        }

        protected override void Disconnect()
        {
            Unsubscribe<PlaySoundMessage>(_audio.PlaySounds);
        }
    }
}