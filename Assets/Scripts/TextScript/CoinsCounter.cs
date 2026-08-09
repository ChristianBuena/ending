using System.Collections;
using UnityEngine;
using TMPro;

public class CoinsCounter : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI coinText;
    [SerializeField] private ResourceStats coinStat;

    void Start()
    {
        coinStat = GameObject.FindWithTag("Coins").GetComponent<ResourceStats>();
    }
    public void UpdateCoinsText()
    {
       coinText.text = $"Coins: {coinStat.CurrentAmount}"; 
    }

}
