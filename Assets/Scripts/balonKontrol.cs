using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balonKontrol : MonoBehaviour
{
    OyunKontrol OyunKontrolScripti;
    public UnityEngine.UI.Text PuanEksi;
    int EksiPuan = 0;
    void Start()
    {
        OyunKontrolScripti = GameObject.Find("_Scripts").GetComponent<OyunKontrol>();
        
        
    }
    public GameObject patlama;
    private void OnMouseDown()
    {
            GameObject go = Instantiate(patlama, transform.position, transform.rotation) as GameObject;
            Destroy(this.gameObject);
            Destroy(go, 0.333f);
            OyunKontrolScripti.PatlayanBalon();
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        string cls = collision.gameObject.name;
        if (cls.Equals("YandınObj"))
        {
            Destroy(this.gameObject);
            EksiPuan--;
        }

    }
}
