using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;
using UnityEngine.Events;

namespace ShooterSpace.Module.BulletObject
{
    public class BulletObjectView : ObjectView<IBulletObjectModel>
    {
        private UnityAction onBulletMove;

        public void SetCallback(UnityAction onMove)
        {
            onBulletMove = onMove;
        }

        protected override void InitRenderModel(IBulletObjectModel model)
        {
            gameObject.SetActive(true);
        }

        protected override void UpdateRenderModel(IBulletObjectModel model)
        {
            
        }

        private void Update()
        {
            onBulletMove?.Invoke();
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.CompareTag("Bound"))
            {
                gameObject.SetActive(false);
            }
        }
    }

}
