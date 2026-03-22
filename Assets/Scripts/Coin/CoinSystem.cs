using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSystem : MonoBehaviour
{
    public PlayersCoins playerCoins; // PlayersCoins scriptine eriþmek için bir referans oluþturuyoruz.
    public GameObject effect; // Coin toplama efektini tutacak bir GameObject referansý.
    void Start()
    {
        playerCoins = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayersCoins>(); // Oyuncu nesnesini bulup PlayersCoins scriptine eriþiyoruz.
    }


    // temas etme methodumuzu kullanacaðýz 
    void OnTriggerEnter2D(Collider2D collision)
    {
        // eðer çarpýþtýðýmýz nesne "Player" tagýna sahipse, yani oyuncu ise, bu koþul saðlanýr.
        if (collision.gameObject.tag  == "Player")
        {
            playerCoins.coin += 10; // Oyuncunun coin sayýsýný 1 artýrýr.
            Destroy(gameObject); // Coin nesnesini yok ederiz.

            Instantiate(effect, transform.position, Quaternion.identity); // Coin toplama efektini oluþtururuz.
        }
    }
}
