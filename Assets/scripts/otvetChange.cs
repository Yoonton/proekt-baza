using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class otvetChange : MonoBehaviour
{
    public GameObject otvet1;
    public GameObject otvet2;
    public GameObject otvet11;
    public GameObject otvet22;
    public GameObject vopros1;
    public GameObject vopros2;
    public GameObject korobka;
    private int rnd;
    private int rnd2;

    void Start()
    {
        rnd = Random.Range(1, 3);
        rnd2 = Random.Range(1, 3);
        if(rnd2 == 1)
        {
            Instantiate(vopros1, new Vector2(korobka.transform.position.x - 19, 0), Quaternion.identity);
            if (rnd == 1)
            {
                Instantiate(otvet1, new Vector2(korobka.transform.position.x, 4.5f), Quaternion.identity);
                Instantiate(otvet2, new Vector2(korobka.transform.position.x, -4.5f), Quaternion.identity);
            }
            if (rnd == 2)
            {
                Instantiate(otvet1, new Vector2(korobka.transform.position.x, -4.5f), Quaternion.identity);
                Instantiate(otvet2, new Vector2(korobka.transform.position.x, 4.5f), Quaternion.identity);
            }
        }
        if(rnd2 == 2)
        {
            Instantiate(vopros2, new Vector2(korobka.transform.position.x - 19, 0), Quaternion.identity);
            if (rnd == 1)
            {
                Instantiate(otvet11, new Vector2(korobka.transform.position.x, 4.5f), Quaternion.identity);
                Instantiate(otvet22, new Vector2(korobka.transform.position.x, -4.5f), Quaternion.identity);
            }
            if (rnd == 2)
            {
                Instantiate(otvet11, new Vector2(korobka.transform.position.x, -4.5f), Quaternion.identity);
                Instantiate(otvet22, new Vector2(korobka.transform.position.x, 4.5f), Quaternion.identity);
            }
        }
    }
}
