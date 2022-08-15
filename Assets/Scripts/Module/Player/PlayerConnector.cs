using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;
using ShooterSpace.Message;

namespace ShooterSpace.Module.Player
{
    public class PlayerConnector : BaseConnector
    {
        private PlayerController player;

        protected override void Connect()
        {
            Subscribe<MovePlayerMessage>(player.OnMove);
        }

        protected override void Disconnect()
        {
            Unsubscribe<MovePlayerMessage>(player.OnMove);
        }
    }

}
