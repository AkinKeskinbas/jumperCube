using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zemin : MonoBehaviour
{
    public float ziplamaKuvveti;
    public bool zemineTemasEdildi;
    private Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.relativeVelocity.y < 0)
        {
            var rb = collision.collider.GetComponent<Rigidbody2D>();
            if (rb!=null)
            {
                var ziplamaVelocity = rb.velocity;
                ziplamaVelocity.y = ziplamaKuvveti;
                rb.velocity = ziplamaVelocity;
                if (zemineTemasEdildi == false)
                {
                    Yönetici.skor++;
                    zemineTemasEdildi = true;
                }
                anim.SetBool("temasEdildi",true);
                Destroy(gameObject, 1f);
            }
        }

       
    }
}
