using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ShooterSpace.Message
{
    public struct ScoreMessage
    {
        public int Score { get; private set; }

        public ScoreMessage(int score)
        {
            Score = score;
        }
    }

}
