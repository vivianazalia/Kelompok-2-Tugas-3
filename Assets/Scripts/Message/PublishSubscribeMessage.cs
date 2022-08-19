using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Agate.MVC.Base;

namespace ShooterSpace.Module.PubSubMessage
{
    public class PublishSubscribeMessage { }

    public struct MovePlayerMessage { }

    public struct ScoreMessage
    {
        public int Score { get; private set; }

        public ScoreMessage(int score)
        {
            Score = score;
        }
    }

    public struct StartGameMessage { }

    public struct BulletSpawnMessage
    {
        public Vector2 position { get; private set; }

        public BulletSpawnMessage(Vector2 pos)
        {
            position = pos;
        }
    }

    public struct BulletShootMessage
    {
        public float Speed { get; private set; }

        public BulletShootMessage(float speed)
        {
            Speed = speed;
        }
    }

    public struct EnemySpawnMessage
    {
        public Vector2 position { get; private set; }

        public EnemySpawnMessage(Vector2 pos)
        {
            position = pos;
        }
    }


    public struct PlaySoundMessage
    {
        public int audioIndex;

        public PlaySoundMessage(int audio)
        {
            this.audioIndex = audio;
        }
    }
    public struct InputLeftMessage { }
    public struct InputRightMessage { }
    public struct InputShootMessage { }

    

    
}
