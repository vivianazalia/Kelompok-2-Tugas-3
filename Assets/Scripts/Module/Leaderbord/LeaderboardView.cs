using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Agate.MVC.Base;

namespace ShooterSpace.Module.Leaderboard
{
    public class LeaderboardView : ObjectView<ILeaderboardModel>
    {
        [SerializeField]
        Transform rankParent;
        RankView[] rank;
        private void Awake()
        {
            rank = rankParent.GetComponentsInChildren<RankView>();
        }

        public void LoadViewLeaderboard(ILeaderboardModel model)
        {
            for(int i = 0; i < 10; i++)
            {
                rank[i].SetNameScore(model.nameRank[i], model.scoreRank[i]);
            }
        }

        protected override void InitRenderModel(ILeaderboardModel model)
        {
            LoadViewLeaderboard(model);
        }

        protected override void UpdateRenderModel(ILeaderboardModel model)
        {
            LoadViewLeaderboard(model);
        }
        

    }
}