using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;
using ShooterSpace.Message;
using ShooterSpace.Gameplay;

namespace ShooterSpace.Module.Player
{
    public class PlayerController : ObjectController<PlayerController, PlayerModel, IPlayerModel, PlayerView>
    {
        public override IEnumerator Initialize()
        {
            yield return base.Initialize();
        }
        public void OnMove(MovePlayerMessage msg)
        {
            Debug.Log("Move Player");
            //if (Input.GetKeyDown(KeyCode.RightArrow))
            //{
            //    _view.transform.position += new Vector3(1 * Time.deltaTime, 0, 0);
            //} 
            //else if (Input.GetKeyDown(KeyCode.LeftArrow))
            //{
            //    _view.transform.position += new Vector3(-1 * Time.deltaTime, 0, 0);
            //}
        }

        private void OnShoot()
        {
            //jika kena enemy, add and publish score
            _model.AddScore();
            Publish<ScoreMessage>(new ScoreMessage(_model.Score));
        }

        private void OnDie()
        {

        }

        private void OnGetPowerUp()
        {

        }

        private void OnDecreaseLife()
        {
            _model.DecreaseLife();
        }

        public override void SetView(PlayerView view)
        {
            base.SetView(view);
        }
    }
}
