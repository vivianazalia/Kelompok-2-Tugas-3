using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;

namespace ShooterSpace.Module.BulletObject
{
    public class BulletObjectController : ObjectController<BulletObjectController, BulletObjectModel, IBulletObjectModel, BulletObjectView>
    {
        public void SetActive(bool b)
        {
            _model.SetActive(b);
        }
    }

}
