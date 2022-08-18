using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Agate.MVC.Base;
using Agate.MVC.Core;

namespace ShooterSpace.Module.Bullet
{
    public class BulletView : ObjectView<IBulletModel>
    {
        private UnityAction onBulletMove;
        protected override void InitRenderModel(IBulletModel model)
        {
            
        }

        protected override void UpdateRenderModel(IBulletModel model)
        {
            
        }

        public void SetCallback(UnityAction onMove)
        {
            onBulletMove = onMove;
        }

        private void Update()
        {
            onBulletMove?.Invoke();
        }
    }
}

