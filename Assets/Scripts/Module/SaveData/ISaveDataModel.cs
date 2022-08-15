using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;

namespace ShooterSpace.Module.SaveData
{
    public interface ISaveDataModel : IBaseModel
    {
        public int Score { get; }
    }
}

