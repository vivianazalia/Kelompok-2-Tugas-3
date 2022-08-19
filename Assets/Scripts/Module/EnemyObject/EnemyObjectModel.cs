using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;

namespace ShooterSpace.Module.EnemyObject
{
    public class EnemyObjectModel : BaseModel, IEnemyObjectModel
    {
        public float DelayShoot { get; private set; }
        public bool IsShoot { get; private set; }
        public float Speed { get; private set; }
        public Vector2 Position { get; private set; }
        public bool IsLeft { get; private set; } = true;

        public EnemyObjectModel()
        {
            DelayShoot = 3;
            IsShoot = true;
            Speed = 2;
        }

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

        public void SetPosition(Vector2 pos)
        {
            Position = pos;
            SetDataAsDirty();
        }

        public void IsLeftMovement(bool isLeft)
        {
            IsLeft = isLeft;
            SetDataAsDirty();
        }
    }

}
