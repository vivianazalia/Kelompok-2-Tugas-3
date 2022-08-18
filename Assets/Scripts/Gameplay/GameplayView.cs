using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;

using ShooterSpace.Module.Character;

namespace ShooterSpace.Gameplay
{
    public class GameplayView : BaseSceneView
    {
        [SerializeField]
        private InputView _input;
        [SerializeField]
        private PlayerView _player;

        public InputView Input => _input;
        public PlayerView Player => _player;
    }

}
