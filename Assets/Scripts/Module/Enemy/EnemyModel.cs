using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;

namespace ShooterSpace.Module.Enemy
{
    public class EnemyModel : BaseModel, IEnemyModel
    {
        public int Life { get; private set; }

        public void SetLife(int life)
        {
            Life = life;
            SetDataAsDirty();
        }

        public void DecreaseLife()
        {
            Life--;
            SetDataAsDirty();
        }
    }

}
