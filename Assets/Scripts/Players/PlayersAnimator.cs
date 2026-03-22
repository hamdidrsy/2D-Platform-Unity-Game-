using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayersAnimator : MonoBehaviour
{
    Animator animt;

    // Start is called before the first frame update
    void Start()
    {
        animt = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");

        if (moveHorizontal == 0)
        {
            animt.SetBool("Move", false);
        }
        else
        {
            animt.SetBool("Move", true);
        }
    }
}
