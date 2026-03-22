using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed; // Düþmanýn hareket hýzýný belirler.
    public Transform pointA; // Düþmanýn hedefi, genellikle oyuncunun konumu.
    public Transform pointB; // Düþmanýn geri döneceði nokta, genellikle baþlangýç konumu.

    private Vector2 targetPosition; // Düþmanýn þu anda hareket ettiði hedef noktasý.
    private bool movingB; // Düþmanýn þu anda pointB'ye mi yoksa pointA'ya mý hareket ettiðini belirten bir bayrak.

    // Diðer script'e eriþmek için referans
    private EnemyFaceDirection faceDirection;

    private void Start()
    {
        targetPosition = pointB.position; // Baþlangýçta düþman pointB'ye hareket eder.
        faceDirection = GetComponent<EnemyFaceDirection>();
    }

    void Update()
    {
        // Düþmanýn hedef noktasýna doðru hareket etmesini saðlar.
        transform.position = Vector2.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
        // Düþman hedef noktasýna ulaþtýðýnda, hedefi deðiþtirir.
        if (Vector2.Distance(transform.position, targetPosition) < 0.1f)
        {
            if (movingB)
            {
                targetPosition = pointA.position; // Eðer þu anda pointB'ye hareket ediyorsa, hedefi pointA yapar.
            }
            else
            {
                targetPosition = pointB.position; // Eðer þu anda pointA'ya hareket ediyorsa, hedefi pointB yapar.
            }
            movingB = !movingB; // Hangi noktaya hareket ettiðini deðiþtirmek için bayraðý tersine çevirir.

            // DÝÐER SCRIPT'TEKÝ FONKSÝYONU ÇAÐIRIR
            if (faceDirection != null)
            {
                faceDirection.Flip();
            }
        }
    }


}
