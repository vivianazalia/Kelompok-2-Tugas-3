using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;
using ShooterSpace.Message;

namespace ShooterSpace.Module.Input
{
    public class InputController : BaseController<InputController>
    {
        public override IEnumerator Initialize()
        {
            yield return base.Initialize();
            OnInput();
        }

        private void OnInput()
        {
            Publish<MovePlayerMessage>(new MovePlayerMessage());
        }
    }

}
