using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class ZeminSpawner : MonoBehaviour
{
    public GameObject zemin;
    private Transform tr;
    public int zeminSayisi;
    public float minX;
    public float minimumY, maksimumY;

    private void Start()
    {
        tr = zemin.GetComponent<Transform>();
        var spawnKonum = new Vector3();
        var yeniScale = new Vector2();
       
        for (int i = 0; i < zeminSayisi; i++)
        {
            yeniScale.x = Random.Range(1.4f, 2.5f);
            yeniScale.y = Random.Range(0.2f, 0.3f);
            tr.localScale = yeniScale;
            spawnKonum.y += Random.Range(minimumY, maksimumY);
            spawnKonum.x  = Random.Range(-minX, minX);

            Instantiate(zemin, spawnKonum, Quaternion.identity);
        }    
    }
}
