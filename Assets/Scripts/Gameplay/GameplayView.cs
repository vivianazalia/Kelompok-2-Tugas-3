using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Agate.MVC.Base;
using Agate.MVC.Core;
using ShooterSpace.Module.Enemy;
using ShooterSpace.Module.Bullet;

namespace ShooterSpace.Gameplay
{
    public class GameplayView : BaseSceneView
    {
        [SerializeField] public EnemyView enemyView;
    }

}
