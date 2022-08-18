using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Agate.MVC.Base;

namespace ShooterSpace.Module.PubSubMessage
{
    public class PublishSubscribeMessage
    {
        
    }

    public struct PlaySoundMessage
    {
        public int audioIndex;

        public PlaySoundMessage(int audio)
        {
            this.audioIndex = audio;
        }
    }
}

