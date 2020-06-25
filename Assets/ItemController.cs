using UnityEngine;
using System.Collections;

public class ItemController : MonoBehaviour
{
    //Unityちゃんのオブジェクト
    private GameObject unitychan;
    //Unityちゃんとアイテムの距離
    private float difference;

    // Use this for initialization
    void Start()
    {
        //Unityちゃんのオブジェクトを取得
        this.unitychan = GameObject.Find("unitychan");
    }

    // Update is called once per frame
    void Update()
    {
        //間隔＝ユニティーちゃんのZ座標の数値ーこのscriptをアタッチしたアイテムの数値
        this.difference = unitychan.transform.position.z - this.transform.position.z;
        //間隔(通り過ぎ)が10以上でフレームアウトしてる
        //間隔が10より大きくなったら(＝離れたら)
        if (this.difference > 10)
        {
            Destroy(this.transform.gameObject);
        }
    }
}