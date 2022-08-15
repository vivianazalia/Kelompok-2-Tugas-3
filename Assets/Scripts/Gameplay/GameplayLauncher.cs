using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;
using ShooterSpace.Boot;
using ShooterSpace.Module.Player;
using ShooterSpace.Module.Enemy;
using ShooterSpace.Module.Input;

namespace ShooterSpace.Gameplay
{
    public class GameplayLauncher : SceneLauncher<GameplayLauncher, GameplayView>
    {
        public override string SceneName => "Gameplay";

        private PlayerController player;
        private EnemyController enemy;

        protected override IConnector[] GetSceneConnectors()
        {
            return new IConnector[]{
                new PlayerConnector()
            };
        }

        protected override IController[] GetSceneDependencies()
        {
            return new IController[]{
                new PlayerController(),
                new EnemyController(), 
                new InputController()
            };
        }

        protected override IEnumerator InitSceneObject()
        {
            player.SetView(_view.playerView);
            enemy.SetView(_view.enemyView);
            yield return null;
        }

        protected override IEnumerator LaunchScene()
        {
            yield return null;
        }
    }

}
