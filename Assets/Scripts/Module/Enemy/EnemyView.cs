using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.Events;
using Agate.MVC.Base;
using Agate.MVC.Core;

namespace ShooterSpace.Module.Enemy
{
    public class EnemyView : ObjectView<IEnemyModel>
    {
        private UnityAction onEnemyMove;

        public void SetCallback(UnityAction onMove)
        {
            onEnemyMove = onMove;
        }

        protected override void InitRenderModel(IEnemyModel model)
        {
            //Debug.Log("Show enemy");
        }

        protected override void UpdateRenderModel(IEnemyModel model)
        {
            //Debug.Log("Update enemy");
        }

        private void Update()
        {
            onEnemyMove?.Invoke();
        }
    }

}
