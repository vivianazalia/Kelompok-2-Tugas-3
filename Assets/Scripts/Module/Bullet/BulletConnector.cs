using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;
using ShooterSpace.Message;

namespace ShooterSpace.Module.Bullet
{
    public class BulletConnector : BaseConnector
    {
        private BulletController bulletPool;

        protected override void Connect()
        {
            Subscribe<BulletShootMessage>(bulletPool.GetBullet);
        }

        protected override void Disconnect()
        {
            Unsubscribe<BulletShootMessage>(bulletPool.GetBullet);
        }
    }
}
