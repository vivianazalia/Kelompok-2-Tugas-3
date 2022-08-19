using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Agate.MVC.Base;
using ShooterSpace.Module.PubSubMessage;

namespace ShooterSpace.Module.Character
{
    public class PlayerController : ObjectController<PlayerController, PlayerView>
    {
        public void MovementLeft(InputLeftMessage message)
        {
            _view.MoveLeft();
        }
        public void MovementRight(InputRightMessage message)
        {
            _view.MoveRight();
        }
        public void Shoot(InputShootMessage message)
        {
            _view.OnShoot();
        }
    }
}
