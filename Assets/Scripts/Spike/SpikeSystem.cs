using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpikeSystem : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // eðer çarpýþtýðýmýz nesne "Player" tagýna sahipse, yani oyuncu ise, bu koþul saðlanýr.
        if (collision.gameObject.tag == "Spike")
        {
            Debug.Log("Spike Engele Çarptýnýz."); // Konsola "Coin collected!" mesajýný yazdýrýr.
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); // Anlýk sahneyi dinamik olarak yükler, böylece oyuncu kaldýðý sahneden yeniden baþlar.
            SceneManager.LoadScene(0); // ilk sahneyi yükler , bu genellikle ana menü veya baþlangýç sahnesidir.

        }
        // eðer çarpýþtýðýmýz nesne "Player" tagýna sahipse, yani oyuncu ise, bu koþul saðlanýr.
        if (collision.gameObject.tag == "Enemies")
        {
            Debug.Log("Enemy Engele Çarptýnýz."); // Konsola "Coin collected!" mesajýný yazdýrýr.
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); // Anlýk sahneyi dinamik olarak yükler, böylece oyuncu kaldýðý sahneden yeniden baþlar.
            SceneManager.LoadScene(0); // ilk sahneyi yükler , bu genellikle ana menü veya baþlangýç sahnesidir.

        }
    }
}