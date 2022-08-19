using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;
using ShooterSpace.Module.PubSubMessage;

namespace ShooterSpace.Module.BulletObject
{
    public class BulletObjectController : ObjectController<BulletObjectController, BulletObjectModel, IBulletObjectModel, BulletObjectView>
    {
        public void Init(BulletObjectModel model, BulletObjectView view)
        {
            _model = model;
            SetView(view);
        }

        public void OnMove()
        {
            _view.transform.position += (Vector3.down * _model.Speed * Time.deltaTime);
            Publish<BulletShootMessage>(new BulletShootMessage(_model.Speed));
        }

        public override void SetView(BulletObjectView view)
        {
            base.SetView(view);
            _view.SetCallback(OnMove);
        }
    }

}
