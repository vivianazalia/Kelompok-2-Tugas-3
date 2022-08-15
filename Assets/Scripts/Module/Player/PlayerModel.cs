using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;

namespace ShooterSpace.Module.Player
{
    public class PlayerModel : BaseModel, IPlayerModel
    {
        public int Life { get; private set; }

        public int Score { get; private set; }

        public void SetLife(int life)
        {
            Life = life;
            SetDataAsDirty();
        }

        public void SetScore(int score)
        {
            Score = score;
            SetDataAsDirty();
        }

        public void DecreaseLife()
        {
            Life--;
            SetDataAsDirty();
        }

        public void AddScore()
        {
            Score++;
            SetDataAsDirty();
        }
    }
}

