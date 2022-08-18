using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;
using ShooterSpace.Module.Enemy;
using ShooterSpace.Message;

public class EnemyConnector : BaseConnector
{
    private EnemyController enemy;

    protected override void Connect()
    {
        //Subscribe<StartGameMessage>(enemy.StartGame);
    }

    protected override void Disconnect()
    {
        //Unsubscribe<StartGameMessage>(enemy.StartGame);
    }
}
