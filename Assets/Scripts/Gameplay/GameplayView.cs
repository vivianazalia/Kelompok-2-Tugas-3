using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Agate.MVC.Base;
using Agate.MVC.Core;
using ShooterSpace.Module.Player;
using ShooterSpace.Module.Enemy;

namespace ShooterSpace.Gameplay
{
    public class GameplayView : BaseSceneView
    {
        [SerializeField] public PlayerView playerView;
        [SerializeField] public EnemyView enemyView;
    }

}
