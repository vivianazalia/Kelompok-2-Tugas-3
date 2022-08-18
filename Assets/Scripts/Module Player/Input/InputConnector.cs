using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Agate.MVC.Base;
using ShooterSpace.Module.PubSubMessage;
using ShooterSpace.Module.Character;

namespace ShooterSpace.Module.InputPlayer
{
    public class InputConnector : BaseConnector
    {
        PlayerController _player;

        protected override void Connect()
        {
            Subscribe<InputLeftMessage>(_player.MovementLeft);
            Subscribe<InputRightMessage>(_player.MovementRight);
            Subscribe<InputShootMessage>(_player.Shoot);
        }

        protected override void Disconnect()
        {
            Unsubscribe<InputLeftMessage>(_player.MovementLeft);
            Unsubscribe<InputRightMessage>(_player.MovementRight);
            Unsubscribe<InputShootMessage>(_player.Shoot);
        }
    }
}
