using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;

namespace ShooterSpace.Module.BulletObject
{
    public class BulletObjectModel : BaseModel, IBulletObjectModel
    {
        public float Speed { get; private set; }
        public Vector2 Position { get; private set; }
        public BulletObjectModel()
        {
            Speed = 4f;
        }

        //public bool IsActive { get; private set; }
        //
        //public void SetActive(bool active)
        //{
        //    IsActive = active;
        //    SetDataAsDirty();
        //}
    }
}

