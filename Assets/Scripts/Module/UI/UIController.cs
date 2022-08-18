using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;

namespace ShooterSpace.Module.UI
{
    public class UIController : ObjectController<UIController, UIView>
    {
        public override void SetView(UIView view)
        {
            base.SetView(view);
            view.SetCallbacks(OnPlayGame);
        }

        public void OnPlayGame()
        {
            Debug.Log("OnPlayGame");
        }
    }

}
