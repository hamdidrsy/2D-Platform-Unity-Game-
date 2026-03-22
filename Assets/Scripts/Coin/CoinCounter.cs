using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CoinCounter : MonoBehaviour
{
    private PlayersCoins playerCoins; // PlayersCoins scriptine eriþmek için bir referans oluþturuyoruz.
    public TextMeshProUGUI coinText; // Coin sayýsýný göstermek için bir TextMeshProUGUI referansý oluþturuyoruz.
    void Start()
    {
        playerCoins = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayersCoins>(); // Oyuncu nesnesini bulup PlayersCoins scriptine eriþiyoruz.
    }

    void Update()
    {
        // Coin sayýsýný günceller ve ekrana yazdýrýr.
        coinText.text = "Coins: " + playerCoins.coin.ToString();
    }

}
