using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;

namespace ShooterSpace.Module.EnemyObject
{
    public class EnemyObjectModel : BaseModel, IEnemyObjectModel
    {
        public float DelayShoot { get; private set; } = 3f;
        public bool IsShoot { get; private set; } = true;

        public void Shoot(bool active)
        {
            IsShoot = active;
            SetDataAsDirty();
        }

        public void SetDelay()
        {
            DelayShoot = 3f;
            SetDataAsDirty();
        }

        public void DecreaseDelayTime()
        {
            DelayShoot -= Time.deltaTime;
            SetDataAsDirty();
        }
    }

}