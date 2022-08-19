using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;

namespace ShooterSpace.Module.BulletObject
{
    public class BulletObjectView : ObjectView<IBulletObjectModel>
    {
        protected override void InitRenderModel(IBulletObjectModel model)
        {
            gameObject.SetActive(true);
        }

        protected override void UpdateRenderModel(IBulletObjectModel model)
        {
            throw new System.NotImplementedException();
        }
    }

}
