using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;
using ShooterSpace.Module.PubSubMessage;

namespace ShooterSpace.Module.Enemy
{
    public class EnemyController : ObjectController<EnemyController, EnemyModel, IEnemyModel, EnemyView>
    { 
        public override IEnumerator Initialize()
        {
            yield return base.Initialize();
            _model.SetTileSize();
        }

        private void SpawnEnemy()
        {
            for (int x = 0; x < _model.BoardSize.x; x++)
            {
                for (int y = 0; y < _model.BoardSize.y; y++)
                {
                    GameObject enemy = Object.Instantiate(_model.Prefab,
                                        new Vector2((_model.StartPos.x + (_model.TileSize.x + _model.Offset.x) * x), (_model.StartPos.y + (_model.TileSize.y + _model.Offset.y) * y)),
                                        _view.transform.rotation);
                    enemy.transform.SetParent(_view.transform);
                    //_model.SetEnemyPosition(x, y, enemy);
                }
            }
        }

        private void OnMove()
        {
            if (_model.IsPlaying)
            {
                OnReachBound();
                if (_model.IsLeft)
                {
                    Vector2 pos = _model.Position + (Vector2.left * _model.MoveSpeed * Time.deltaTime);
                    _model.SetPosition(pos);
                    _view.transform.position = _model.Position;
                }
                else
                {
                    Vector2 pos = _model.Position + (Vector2.right * _model.MoveSpeed * Time.deltaTime);
                    _model.SetPosition(pos);
                    _view.transform.position = _model.Position;
                }
            }
        }

        private void OnReachBound()
        {
            if(_model.Position.x >= _model.MaxRightPos.x)
            {
                _model.IsLeftMovement(true);
            }
            else if(_model.Position.x <= _model.MaxLeftPos.x)
            {
                _model.IsLeftMovement(false);
            }
        }

        private void OnShoot()
        {
            //publish bullet spawn
        }

        private void OnDie()
        {

        }

        private void OnDecreaseLife()
        {
            _model.DecreaseLife();
        }

        public override void SetView(EnemyView view)
        {
            base.SetView(view);
            SpawnEnemy();
            _view.SetCallback(OnMove);
        }
    }

}
