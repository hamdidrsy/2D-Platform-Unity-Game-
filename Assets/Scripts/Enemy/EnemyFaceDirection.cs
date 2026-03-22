using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFaceDirection : MonoBehaviour
{
    public void Flip()
    {
        //karakterin ölçeðini x ekseninde -1 ile çarparak karakterin yönünü deðiþtiriyoruz. Bu, karakterin görsel olarak dönmesini saðlar.
        Vector2 scaler = transform.localScale;
        //karakterin ölçeðini x ekseninde -1 ile çarparak karakterin yönünü deðiþtiriyoruz. Bu, karakterin görsel olarak dönmesini saðlar.
        scaler.x *= -1;
        //karakterin ölçeðini x ekseninde -1 ile çarparak karakterin yönünü deðiþtiriyoruz. Bu, karakterin görsel olarak dönmesini saðlar.
        transform.localScale = scaler;
    }
}
