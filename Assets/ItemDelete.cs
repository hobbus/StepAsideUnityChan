using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDelete : MonoBehaviour
{
    private GameObject unitychan;

    // Start is called before the first frame update
    void Start()
    {
        this.unitychan = GameObject.Find("unitychan");

    }

    // Update is called once per frame
    void Update()
    {
        //通り過ぎたゲームオブジェクトを破壊する
        if (this.transform.position.z <= (unitychan.transform.position.z) - 5)
        {
            Destroy(this.gameObject);
        }
    }
}
