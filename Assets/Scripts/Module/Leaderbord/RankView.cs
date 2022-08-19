using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RankView : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI rankNameText;
    [SerializeField]
    TextMeshProUGUI rankScoreText;
    public void SetNameScore(string name, int score)
    {
        rankNameText.text = name;
        rankScoreText.text = score.ToString();
    }


}
