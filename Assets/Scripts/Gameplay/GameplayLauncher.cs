using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;
using ShooterSpace.Boot;
using ShooterSpace.Module.Enemy;
using ShooterSpace.Module.EnemyObject;
using ShooterSpace.Module.UI;
using ShooterSpace.Module.Bullet;
using ShooterSpace.Module.InputPlayer;
using ShooterSpace.Module.Character;
using ShooterSpace.Module.Soundfx;

namespace ShooterSpace.Gameplay
{
    public class GameplayLauncher : SceneLauncher<GameplayLauncher, GameplayView>
    {
        public override string SceneName => "Gameplay";

        private EnemyController enemy;
        private BulletController bullet;
        private InputController _input;
        private PlayerController _player;


        protected override IConnector[] GetSceneConnectors()
        {
            return new IConnector[]{
                new EnemyConnector(),
                new BulletConnector(),
                new InputConnector()
            };
        }

        protected override IController[] GetSceneDependencies()
        {
            return new IController[]{
                new EnemyController(),
                new UIController(),
                new BulletController(),
                new PlayerController(),
                new SoundfxController(),
                new InputController()
            };
        }

        protected override IEnumerator InitSceneObject()
        {
            enemy.SetView(_view.enemyView);
            bullet.SetView(_view.bulletView);
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
