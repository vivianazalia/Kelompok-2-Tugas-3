using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;

namespace ShooterSpace.Module.Enemy
{
    public class EnemyView : ObjectView<IEnemyModel>
    {
        protected override void InitRenderModel(IEnemyModel model)
        {
            //Debug.Log("Show enemy");
        }

        protected override void UpdateRenderModel(IEnemyModel model)
        {
            //Debug.Log("Update enemy");
        }
    }

}
