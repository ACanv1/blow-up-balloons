using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OyunKontrol : MonoBehaviour
{
    public UnityEngine.UI.Text PuanText, SureText,ScoreText;
    public float Sure = 5;
    public int Puan = 0;
    public GameObject sonrakilvlBTN;
    public GameObject patlama;
    balonKontrol BalonScripti;
    void Start()
    {
        PuanText.text = "Puan : " + Puan;
    }

    
    void Update()
    {
        if (Sure>0) {
            Sure -= Time.deltaTime;
            SureText.text = "Süre ; " + (int)Sure;

        }
        else
        {
            GameObject[] go = GameObject.FindGameObjectsWithTag("balon");
            
            for (int i = 0; i < go.Length; i++)
            {
                Destroy(go[i]);
                Instantiate(patlama, go[i].transform.position, go[i].transform.rotation);
            }
            ScoreText.text = "Score "+Puan;

            sonrakilvlBTN.gameObject.SetActive(true);
            

            
        }
    }
    public void PatlayanBalon()
    {
        Puan += 1;
        PuanText.text = "Puan : " + Puan;
        
        
    }

    
}
