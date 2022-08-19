using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;
using ShooterSpace.Module.PubSubMessage;

namespace ShooterSpace.Module.EnemyObject
{
    public class EnemyObjectController : ObjectController<EnemyObjectController, EnemyObjectModel, IEnemyObjectModel, EnemyObjectView>
    {
        public void OnShoot()
        {
            _model.DecreaseDelayTime();
            if (_model.DelayShoot <= 0)
            {
                Publish<BulletShootMessage>(new BulletShootMessage(_view.transform.position));
                _model.SetDelay();
            }
        }

        public override void SetView(EnemyObjectView view)
        {
            base.SetView(view);
            _view.SetCallback(OnShoot);
        }
    }
}
