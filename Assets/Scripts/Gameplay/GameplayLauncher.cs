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

namespace ShooterSpace.Gameplay
{
    public class GameplayLauncher : SceneLauncher<GameplayLauncher, GameplayView>
    {
        public override string SceneName => "Gameplay";

        private EnemyController enemy;
        private BulletController bullet;


        protected override IConnector[] GetSceneConnectors()
        {
            return new IConnector[]{
                new EnemyConnector(),
                new BulletConnector()
            };
        }

        protected override IController[] GetSceneDependencies()
        {
            return new IController[]{
                new EnemyController(),
                new UIController(),
                new BulletController()
            };
        }

        protected override IEnumerator InitSceneObject()
        {
            enemy.SetView(_view.enemyView);
            bullet.SetView(_view.bulletView);
            yield return null;
        }

        protected override IEnumerator LaunchScene()
        {
            yield return null;
        }
    }

}
