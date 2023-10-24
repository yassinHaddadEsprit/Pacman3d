using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CoinCounter : MonoBehaviour
{
    public static CoinCounter instance;

    public TMP_Text coinText;
    public int currentCoins = 0;

    private void Awake()
    {
        instance = this; 
    }
    // Start is called before the first frame update
    void Start()
    {
        coinText.text = "Coins :" + currentCoins.ToString();
    }

    // Update is called once per frame
    public void IncreaseCoins()
    {
        currentCoins += 1;
        coinText.text = "Coins :" + currentCoins.ToString();
    }
}
