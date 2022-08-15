using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;

namespace ShooterSpace.Module.Player
{
    public interface IPlayerModel : IBaseModel
    {
        public int Life { get; }
        public int Score { get; }
    }

}
