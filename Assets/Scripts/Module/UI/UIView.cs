using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Agate.MVC.Base;
using Agate.MVC.Core;
using UnityEngine.Events;

namespace ShooterSpace.Module.UI
{
    public class UIView : BaseView
    {
        public void SetCallbacks(UnityAction onClickPlayButton)
        {
            Debug.Log("set callback");
            //playButton.onClick.RemoveAllListeners();
            //playButton.onClick.AddListener(onClickPlayButton);
        }
    }
}

