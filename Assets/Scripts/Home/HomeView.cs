using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;
using UnityEngine.Events;
using ShooterSpace.Boot;
using TMPro;
using UnityEngine.UI;

namespace ShooterSpace.Home
{
    public class HomeView : BaseSceneView
    {
        [SerializeField] private Button _playButton;

        public void SetCallbacks(UnityAction onClickPlayButton)
        {
            _playButton.onClick.RemoveAllListeners();
            _playButton.onClick.AddListener(onClickPlayButton);
        }
    }
}
