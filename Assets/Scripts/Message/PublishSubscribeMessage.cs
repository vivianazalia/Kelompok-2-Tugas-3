using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Agate.MVC.Base;

namespace ShooterSpace.Module.PubSubMessage
{
    public struct PlaySoundMessage
    {
        public int audioIndex;

        public PlaySoundMessage(int audio)
        {
            this.audioIndex = audio;
        }
    }

    public struct MovePlayerMessage
    {

    }

    public struct ScoreMessage
    {
        public int Score { get; private set; }

        public ScoreMessage(int score)
        {
            Score = score;
        }
    }

    public struct StartGameMessage
    {

    }
}

