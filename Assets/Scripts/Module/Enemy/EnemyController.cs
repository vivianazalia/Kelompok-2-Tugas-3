using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;

namespace ShooterSpace.Module.Enemy
{
    public class EnemyController : ObjectController<EnemyController, EnemyModel, IEnemyModel, EnemyView>
    {
        public override IEnumerator Initialize()
        {
            yield return base.Initialize();
            OnSetTileSize();
        }

        private void SpawnEnemy()
        {
            for(int x = 0; x < _model.BoardSize.x; x++)
            {
                for(int y = 0; y < _model.BoardSize.y; y++)
                {
                    GameObject enemy = Object.Instantiate(_model.Prefab, 
                                        new Vector2((_model.StartPos.x + (_model.TileSize.x + _model.Offset.x) * x), (_model.StartPos.y + (_model.TileSize.y + _model.Offset.y) * y)), 
                                        _view.transform.rotation);
                    enemy.transform.SetParent(_view.transform);
                    //_model.SetEnemyPosition(x, y, enemy);
                }
            }
        }

        private void OnSetTileSize()
        {
            _model.SetTileSize();
        }

        private void OnMove()
        {
           
        }

        private void OnShoot()
        {

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
        }
    }

}
