using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;

namespace ShooterSpace.Module.Enemy
{
    public class EnemyController : ObjectController<EnemyController, EnemyModel, IEnemyModel, EnemyView>
    {
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
        }
    }

}
