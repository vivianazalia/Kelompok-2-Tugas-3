using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;
using ShooterSpace.Module.PubSubMessage;
using ShooterSpace.Module.EnemyObject;

namespace ShooterSpace.Module.Enemy
{
    public class EnemyController : ObjectController<EnemyController, EnemyModel, IEnemyModel, EnemyView>
    {
        private List<GameObject> enemies = new List<GameObject>();

        public GameObject CreateInstanceObject()
        {
            EnemyObjectModel enemyModel = new EnemyObjectModel();
            GameObject prefab = Resources.Load<GameObject>("Prefabs/Enemy");
            GameObject enemyObj = Object.Instantiate(prefab);
            EnemyObjectView enemyView = enemyObj.GetComponent<EnemyObjectView>();
            EnemyObjectController enemyController = new EnemyObjectController();
            InjectDependencies(enemyController);
            enemyController.Init(enemyModel, enemyView);
            return enemyObj;
        }
        public override IEnumerator Initialize()
        {
            yield return base.Initialize();
            //_model.SetTileSize();
            SpawnEnemy();
        }

        private void SpawnEnemy()
        { 
            for (int x = 0; x < _model.BoardSize.x; x++)
            {
                for (int y = 0; y < _model.BoardSize.y; y++)
                {
                    GameObject enemy = CreateInstanceObject();
                    enemies.Add(enemy);
                    Vector2 pos = new Vector2((_model.StartPos.x + (_model.TileSize.x + _model.Offset.x) * x), (_model.StartPos.y + (_model.TileSize.y + _model.Offset.y) * y));
                    enemy.transform.position = pos;
                    Publish<EnemySpawnMessage>(new EnemySpawnMessage(pos));
                    //GameObject enemy = Object.Instantiate(_model.Prefab,new Vector2((_model.StartPos.x + (_model.TileSize.x + _model.Offset.x) * x), (_model.StartPos.y + (_model.TileSize.y + _model.Offset.y) * y)), _view.transform.rotation);
                    //enemy.transform.SetParent(_view.transform);
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

        public override void SetView(EnemyView view)
        {
            base.SetView(view);
            _view.SetCallback(OnMove);
        }
    }

}
