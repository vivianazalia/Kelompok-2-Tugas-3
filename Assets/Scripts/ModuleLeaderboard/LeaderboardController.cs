using System.Collections;
using System.Collections.Generic;
using UnityEngine;


using Agate.MVC.Base;


namespace ShooterSpace.Module.Leaderboard
{
    public class LeaderboardController : ObjectController<LeaderboardController, LeaderboardModel, ILeaderboardModel, LeaderboardView>
    {
        // panggil fungsi ini saat gameover
        public void AddNewScore(string name, int score)
        {
            _model.AddData(name, score);
        }

        public override void SetView(LeaderboardView view)
        {
            base.SetView(view);
        }
        public override IEnumerator Finalize()
        {
            _model.LoadData();
            return base.Finalize();
        }

    }
}
