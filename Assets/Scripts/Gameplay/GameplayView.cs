using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Agate.MVC.Base;
using Agate.MVC.Core;
using ShooterSpace.Module.Enemy;
using ShooterSpace.Module.Bullet;
using ShooterSpace.Module.InputPlayer;
using ShooterSpace.Module.Character;
using ShooterSpace.Module.Soundfx;

namespace ShooterSpace.Gameplay
{
    public class GameplayView : BaseSceneView
    {
        [SerializeField] 
        public EnemyView enemyView;
        //[SerializeField] 
        //public BulletView bulletView;
        [SerializeField]
        private InputView _input;
        [SerializeField]
        private PlayerView _player;

        public InputView Input => _input;
        public PlayerView Player => _player;
    }

}
