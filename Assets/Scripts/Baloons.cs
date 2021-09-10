using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Baloons : MonoBehaviour
{
    public GameObject Balon;
    float Hızı = 1f;
    float zamansayac = 0f;
    OyunKontrol ok;
    // Start is called before the first frame update
    void Start()
    {
        ok = this.gameObject.GetComponent<OyunKontrol>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
        zamansayac -= Time.deltaTime*2;
        if (zamansayac<0 && ok.Sure>0)
        {
            GameObject go = Instantiate(Balon, new Vector3(Random.Range(-2.2f, 2.2f), -6f, 0), Quaternion.Euler(0, 0, 0)) as GameObject;
            go.GetComponent<Rigidbody2D>().AddForce(new Vector3(0,Random.Range( 75f,120f), 0));
            zamansayac = Hızı;
        }
    }
}
