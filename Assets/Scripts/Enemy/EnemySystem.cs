using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemySystem : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {

        // eðer çarpýþtýðýmýz nesne "Player" tagýna sahipse, yani oyuncu ise, bu koþul saðlanýr.
        if (collision.gameObject.tag == "Enemy")
        {
            Debug.Log("Enemy Engele Çarptýnýz."); // Konsola "Coin collected!" mesajýný yazdýrýr.
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); // Anlýk sahneyi dinamik olarak yükler, böylece oyuncu kaldýðý sahneden yeniden baþlar.
            SceneManager.LoadScene(0); // ilk sahneyi yükler , bu genellikle ana menü veya baþlangýç sahnesidir.

        }
    }
}
