using UnityEngine;

public class EnemySystem : MonoBehaviour
{
    [SerializeField, Header("敵人資料")]
    private DataEnemy data;
    [SerializeField, Header("玩家物件名稱")]
    private string namePlayer = "刺客";

    private Transform traPlayer;

    private void Awake()
    {
        traPlayer = GameObject.Find(namePlayer).transform;

        //float result = Mathf.Lerp(0, 100, 0.5f);
        //print("0與 100 的 0.5 插值結果:" + result);
    }

    float a = 0;
    float b = 1000;

    private void Update()
    {
        //a = Mathf.Lerp(a, b, 0.5f);
        //print("測試結果:" + a);
        MoveToPlayer();
    }

    private void MoveToPlayer()
    {
        Vector3 posEnemy = transform.position;
        Vector3 posPlayer = traPlayer.position;

        transform.position = Vector3.Lerp(posEnemy, posPlayer, 0.5f * data.speed * Time.deltaTime);

        float y = transform.position.x > traPlayer.position.x ? 180 : 0;
        transform.eulerAngles = new Vector3(0, y, 0);
    }
}
