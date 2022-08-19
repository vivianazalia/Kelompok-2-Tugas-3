using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;
using ShooterSpace.Module.EnemyObject;
using ShooterSpace.Message;

public class EnemyObjectConnector : BaseConnector
{
    private EnemyObjectController enemy;

    protected override void Connect()
    {
        Subscribe<BulletShootMessage>(enemy.OnShootMsg);
    }

    protected override void Disconnect()
    {
        Unsubscribe<BulletShootMessage>(enemy.OnShootMsg);
    }
}
