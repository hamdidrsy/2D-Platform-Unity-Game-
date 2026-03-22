using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayersMoveController : MonoBehaviour
{
    //hýzýmýzý tanýmlamak için kullanacaðýmýz float. Bu, karakterin hareket hýzýný belirler.
    public float speed;
    // rb: fiziði algýlamamýzý saðlar
    Rigidbody2D rb;
    //karakterin hangi yöne baktýðýný kontrol etmek için kullanacaðýmýz boolean. Bu, karakterin saða mý yoksa sola mý baktýðýný kontrol etmek için kullanýlýr.
    bool facingRight = true;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //baþlangýçta karakterin saða baktýðýný varsayýyoruz, bu yüzden facingRight'ý true yapýyoruz.
        facingRight = true;
    }

    // Update is called once per frame
    void Update()
    {
        //yatay hareket için Input.GetAxis("Horizontal") kullanarak yatay eksende hareketi kontrol ediyoruz. Bu, klavyenin sað ve sol ok tuþlarý veya A ve D tuþlarý ile karakterin hareketini saðlar. Elde edilen deðeri moveHorizontal deðiþkenine atýyoruz.
        float moveHorizontal = Input.GetAxis("Horizontal");
        //hareketi uygulamak için rb.velocity'yi kullanarak karakterin hýzýný ayarlýyoruz. Yatay hareket için moveHorizontal'ý speed ile çarparak x hýzýný belirliyoruz ve y hýzýný mevcut y hýzýný koruyarak ayarlýyoruz.
        rb.velocity = new Vector2(moveHorizontal * speed, rb.velocity.y);
        //karakterin hareket yönüne göre dönmesini saðlamak için moveHorizontal deðerini kontrol ediyoruz. Eðer moveHorizontal pozitifse ve karakter saða bakmýyorsa, Flip() fonksiyonunu çaðýrarak karakteri saða döndürüyoruz. Eðer moveHorizontal negatifse ve karakter sola bakmýyorsa, Flip() fonksiyonunu çaðýrarak karakteri sola döndürüyoruz.
        if (moveHorizontal > 0 && !facingRight)
        {
            Flip();
        }//karakterin hareket yönüne göre dönmesini saðlamak için moveHorizontal deðerini kontrol ediyoruz. Eðer moveHorizontal pozitifse ve karakter saða bakmýyorsa, Flip() fonksiyonunu çaðýrarak karakteri saða döndürüyoruz. Eðer moveHorizontal negatifse ve karakter sola bakmýyorsa, Flip() fonksiyonunu çaðýrarak karakteri sola döndürüyoruz.
        else if (moveHorizontal < 0 && facingRight)
        {
            Flip();
        }
    }

    //karakterin dönmesini saðlayan fonksiyon. Bu fonksiyon, facingRight boolean'ýný tersine çevirir ve karakterin ölçeðini x ekseninde -1 ile çarparak karakterin yönünü deðiþtirir.
    private void Flip()
    {
        //facingRight boolean'ýný tersine çeviriyoruz. Eðer karakter saða bakýyorsa, artýk sola bakacak ve tersi de geçerlidir.
        facingRight = !facingRight;
        //karakterin ölçeðini x ekseninde -1 ile çarparak karakterin yönünü deðiþtiriyoruz. Bu, karakterin görsel olarak dönmesini saðlar.
        Vector2 scaler = transform.localScale;
        //karakterin ölçeðini x ekseninde -1 ile çarparak karakterin yönünü deðiþtiriyoruz. Bu, karakterin görsel olarak dönmesini saðlar.
        scaler.x *= -1;
        //karakterin ölçeðini x ekseninde -1 ile çarparak karakterin yönünü deðiþtiriyoruz. Bu, karakterin görsel olarak dönmesini saðlar.
        transform.localScale = scaler;
    }
}