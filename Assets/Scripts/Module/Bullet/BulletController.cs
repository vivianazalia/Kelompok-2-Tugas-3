using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;
using ShooterSpace.Module.BulletObject;
using ShooterSpace.Module.PubSubMessage;

namespace ShooterSpace.Module.Bullet
{
    public class BulletController : ObjectController<BulletController, BulletModel, IBulletModel, BulletView>
    {
        public override IEnumerator Initialize()
        {
            yield return base.Initialize();
            _model.SetPrefab();
        }

        public void OnMove()
        {
            //bullet spawn dan nembak ke atas
            _view.transform.position += (Vector3.up * _model.Speed * Time.deltaTime);
        }

        public void GetBullet(BulletShootMessage msg)
        {
            GameObject bullet = _model.GetBullet();
            if(bullet == null)
            {
                bullet = Object.Instantiate(_model.Prefab, _view.transform.position, Quaternion.identity);
                _model.AddBulletToPool(bullet);
            }

            bullet.transform.position = msg.position;
        }

        public override void SetView(BulletView view)
        {
            base.SetView(view);
            _view.SetCallback(OnMove);
        }
    }
}
