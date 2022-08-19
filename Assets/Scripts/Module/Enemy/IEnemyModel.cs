using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;

namespace ShooterSpace.Module.Enemy
{
    public interface IEnemyModel : IBaseModel
    {
        public int Life { get; }
    }

}
