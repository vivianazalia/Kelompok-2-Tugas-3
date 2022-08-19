using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;
using UnityEngine.Events;
using ShooterSpace.Module.PubSubMessage;

namespace ShooterSpace.Module.EnemyObject
{
    public class EnemyObjectView : ObjectView<IEnemyObjectModel>
    {
        private UnityAction onEnemyShoot;
        //private UnityAction onEnemyMove;
        //private UnityAction<EnemySpawnMessage> onEnemySetPos;

        public void SetCallback(UnityAction onShoot)
        {
            onEnemyShoot = onShoot;
        }

        protected override void InitRenderModel(IEnemyObjectModel model)
        {
            
        }

        protected override void UpdateRenderModel(IEnemyObjectModel model)
        {
            
        }

        private void Update()
        {
            onEnemyShoot?.Invoke();
        }
    }
}

