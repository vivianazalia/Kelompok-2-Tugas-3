using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

using Agate.MVC.Base;


namespace ShooterSpace.Module.Leaderboard
{
    public class LeaderboardModel : BaseModel, ILeaderboardModel
    {
        public string[] nameRank { get; private set; } = new string[11];//save name player berdasarkan rank score
        public int[] scoreRank { get; private set; } = new int[11]; // save score player berdasarkan rank score


        /*
         * urutan yang dipanggil
         * LoadData()
         * AddData()
         * SortData()
         * SaveData()
         */

        public void AddData(string newName, int newScore)
        {
            LoadData();
            nameRank[10] = newName;
            scoreRank[10] = newScore;
            SortData();
            SaveData();

            SetDataAsDirty();
        }

        void SaveData()
        {
            for(int i = 0; i < 10; i++)
            {
                int b = i + 1;
                string temp = nameRank[i].ToString() +":"+ scoreRank[i].ToString();
                PlayerPrefs.SetString("scoreRank " + b, temp);
            }
        }

        // contoh data : "Budi:23"

        public void LoadData()
        {
            for (int i = 0; i < 10; i++)
            {
                int b = 1 + i;
                PlayerPrefs.SetString("scoreRank " + b, "Budi:"+b);
            }

            string[] dataTemp = new string[10];
            int k = 0;
            for (int i = 0; i < 10; i++)
            {
                int b = 1 + i;
                dataTemp[i] = PlayerPrefs.GetString("scoreRank " + b);
                string[] dataTempSplit = dataTemp[i].Split(":");
                nameRank[k] = dataTempSplit[0];
                scoreRank[k] = Int32.Parse(dataTempSplit[1]);
                k++;
            }

        }


        // sorting score dan nama dimulai dari score yang terbesar
        public void SortData()
        {
            for (int i = 0; i < scoreRank.Length; i++)
            {
                for (int j = i + 1; j < scoreRank.Length; j++)
                {
                    if (scoreRank[i] < scoreRank[j])
                    {
                        int tempScore;
                        string tempName;

                        // swap score
                        tempScore = scoreRank[i];
                        scoreRank[i] = scoreRank[j];
                        scoreRank[j] = tempScore;

                        // swap name Player
                        tempName = nameRank[i];
                        nameRank[i] = nameRank[j];
                        nameRank[j] = tempName;
                    }
                }
            }
        }

    }
}
