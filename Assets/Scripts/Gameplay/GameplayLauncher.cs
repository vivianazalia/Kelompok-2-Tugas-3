using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;
using ShooterSpace.Boot;
using ShooterSpace.Module.Soundfx;
using ShooterSpace.Module.InputPlayer;
using ShooterSpace.Module.Character;

namespace ShooterSpace.Gameplay
{
    public class GameplayLauncher : SceneLauncher<GameplayLauncher, GameplayView>
    {
        public override string SceneName => "Gameplay";
        private InputController _input;
        private PlayerController _player;


        protected override IConnector[] GetSceneConnectors()
        {
            return new IConnector[]{
                new InputConnector()
            };
        }

        protected override IController[] GetSceneDependencies()
        {
            return new IController[]{
                new PlayerController(),
                new SoundfxController(),
                new InputController()
            };
        }

        protected override IEnumerator InitSceneObject()
        {
            _input.SetView(_view.Input);
            _player.SetView(_view.Player);
            yield return null;
        }

        protected override IEnumerator LaunchScene()
        {
            _input.Init();
            yield return null;
        }
    }

}
