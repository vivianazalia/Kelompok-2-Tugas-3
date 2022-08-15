using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;

namespace ShooterSpace.Module.SaveData
{
    public class SaveDataController : DataController<SaveDataController, SaveDataModel, ISaveDataModel>
    {
        public void SaveData()
        {

        }

        public void LoadData()
        {

        }

        public void OnUpdateScore(int score)
        {
            _model.SetScore(score);
        }
    }
}

