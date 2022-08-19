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
        public void Init(EnemyObjectModel model, EnemyObjectView view)
        {
            _model = model;
            SetView(view);
            _model.SetPosition(_view.transform.position);
        }

        public void OnShoot()
        {
            _model.DecreaseDelayTime();
            if (_model.DelayShoot <= 0)
            {
                Publish<BulletSpawnMessage>(new BulletSpawnMessage(_view.transform.position));
                _model.SetDelay();
            }
        }

        public void OnShootMsg(BulletShootMessage msg)
        {
            OnShoot();
        }

        private void OnMove()
        {
            OnReachBound();
            if (_model.IsLeft)
            {
                Vector2 pos = _model.Position + (Vector2.left * _model.Speed * Time.deltaTime);
                _model.SetPosition(pos);
                _view.transform.position = _model.Position;
            }
            else
            {
                Vector2 pos = _model.Position + (Vector2.right * _model.Speed * Time.deltaTime);
                _model.SetPosition(pos);
                _view.transform.position = _model.Position;
            }
        }

        public void OnSetPosition(EnemySpawnMessage msg)
        {
            Debug.Log(msg.position);
            _model.SetPosition(msg.position);
        }

        private void OnReachBound()
        {
            if (_model.Position.x >= _model.MaxRightPos.x)
            {
                _model.IsLeftMovement(true);
            }
            else if (_model.Position.x <= _model.MaxLeftPos.x)
            {
                _model.IsLeftMovement(false);
            }
        }

        public override void SetView(EnemyObjectView view)
        {
            base.SetView(view);
            _view.SetCallback(OnShoot, OnMove);
        }
    }
}
