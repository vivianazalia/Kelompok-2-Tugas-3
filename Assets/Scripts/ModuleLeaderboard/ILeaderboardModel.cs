using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;


namespace ShooterSpace.Module.Leaderboard
{
    public interface ILeaderboardModel : IBaseModel
    {
        string[] nameRank { get; }
        int[] scoreRank { get; }
    }
}
