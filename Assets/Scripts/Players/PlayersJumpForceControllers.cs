using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayersJumpForceControllers : MonoBehaviour
{
    // rb: fiziði algýlamamýzý saðlar
    Rigidbody2D rb;
    //zýplama kuvvetimiz
    public float jumpForce;
    //zemin kontrolü için kullanacaðýmýz transform neden? Çünkü zeminin tam olarak nerede olduðunu bilmemiz gerekiyor. Bu transform'u zemin kontrolü için kullanacaðýz.
    public Transform graundCheck;
    //zemin katmanýný tanýmlamak için kullanacaðýmýz LayerMask. Bu, zeminin hangi katmanda olduðunu belirtmek için kullanýlýr.
    public LayerMask groundLayer;
    //zemin kontrolü için kullanacaðýmýz yarýçap. Bu, zeminin ne kadar geniþ bir alanda kontrol edileceðini belirler.
    public float groundCheckRadius = 0.5f;
    //zemin kontrolü için kullanacaðýmýz boolean. Bu, karakterin zeminde olup olmadýðýný kontrol etmek için kullanýlýr.
    bool isGrounded;
    //zýplama kontrolü için kullanacaðýmýz boolean. Bu, karakterin zýplama durumunu kontrol etmek için kullanýlýr.
    bool isJumping;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //zemin kontrolü için OverlapCircle kullanarak zeminin içinde olup olmadýðýmýzý kontrol ediyoruz. Bu, graundCheck pozisyonunda, groundCheckRadius yarýçapýnda ve groundLayer katmanýnda bir çember oluþturur ve bu çemberin içinde herhangi bir zemin olup olmadýðýný kontrol eder.
        isGrounded = Physics2D.OverlapCircle(graundCheck.position, groundCheckRadius, groundLayer);
        //zýplama kontrolü için Space tuþuna basýldýðýnda ve karakter zeminde olduðunda zýplama kuvveti uyguluyoruz. Bu, rb'nin mevcut x hýzýný koruyarak y hýzýný jumpForce olarak ayarlar.
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded == true){
            //zýplama kuvveti uygulama
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            //zýplama durumunu true yapýyoruz çünkü karakter zýplamaya baþladý.
            isJumping = true;
        }
        //zemin kontrolü yaparak karakterin zýplama durumunu sýfýrlýyoruz. Eðer karakter zeminde ise ve zýplama durumunda ise, zýplama durumunu false yapýyoruz çünkü karakter artýk zýplamýyor.
        if (isGrounded && isJumping)
        {
            //zýplama durumunu sýfýrlama
            isJumping = false;
        }
    }
}
