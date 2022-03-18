using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KarakterHareket : MonoBehaviour
{
   public float hareketHızı;
   private float yatayHareket;
   private Rigidbody2D rb;
   
   private void Start()
   {
      rb = GetComponent<Rigidbody2D>();
   }

   private void Update()
   {
      yatayHareket = Input.GetAxis("Horizontal");
      
      
      yatayHareket = Input.GetAxis("Horizontal");
      rb.velocity = new Vector2(yatayHareket * hareketHızı * Time.deltaTime, rb.velocity.y);
      
      //karakter yon degistirme
      Vector2 yeniScale = transform.localScale;

      if (yatayHareket > 0)
      {
         yeniScale.x = 0.05f;
      }

      if (yatayHareket < 0)
      {
         yeniScale.x = -0.05f;
      }

      transform.localScale = yeniScale;
   }
}
