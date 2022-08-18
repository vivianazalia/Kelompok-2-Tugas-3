using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using Agate.MVC.Base;
using Agate.MVC.Core;

namespace ShooterSpace.Module.Player
{
    public class PlayerView : ObjectView<IPlayerModel>
    {
        protected override void InitRenderModel(IPlayerModel model)
        {
            //Debug.Log("Show player");
            gameObject.SetActive(true);
        }

        protected override void UpdateRenderModel(IPlayerModel model)
        {
            //Debug.Log("Update player");
        }
    }
}

