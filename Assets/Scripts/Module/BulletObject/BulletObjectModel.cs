using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;

namespace ShooterSpace.Module.BulletObject
{
    public class BulletObjectModel : BaseModel, IBulletObjectModel
    {
        public bool IsActive { get; private set; }

        public void SetActive(bool active)
        {
            IsActive = active;
            SetDataAsDirty();
        }
    }
}

