
using UnityEngine;

public class EnemySystem : MonoBehaviour
{
    [SerializeField, Header("�ĤH���")]
    private DataEnemy data;
    [SerializeField, Header("���a����W��")]
    private string namePlayer = "���";

    private Transform traPlayer;
	private float timerAttack;
	private Animator ani;
	private string parameterAttack = "觸發攻擊";

    private void Awake()
    {
        ani = GetComponent<Animator>();
		
		traPlayer = GameObject.Find(namePlayer).transform;

        //float result = Mathf.Lerp(0, 100, 0.5f);
        //print("0�P 100 �� 0.5 ���ȵ��G:" + result);
    }

    float a = 0;
    float b = 1000;

    private void Update()
    {
        //a = Mathf.Lerp(a, b, 0.5f);
        //print("���յ��G:" + a);
        MoveToPlayer();
    }
	
	private void OnDrawGizmos()
	{
		Gizmos.color = new Color(1, 0.5f, 0, 0.5f);
		Gizmos.DrawSphere(transform.position, data.stopDistance);
	}

    private void MoveToPlayer()
    {
        Vector3 posEnemy = transform.position;
        Vector3 posPlayer = traPlayer.position;
		
		float dis = Vector3.Distance(posEnemy, posPlayer);
		//print("<color=yellow>distance : " + dis + "</color>");
		
		if (dis < data.stopDistance)
		{
			Attack();
		}
		else
		{
			transform.position = Vector3.Lerp(posEnemy, posPlayer, 0.5f * data.speed * Time.deltaTime);

            float y = transform.position.x > traPlayer.position.x ? 180 : 0;
            transform.eulerAngles = new Vector3(0, y, 0);
		}
    }
	
	private void Attack()
	{
		if(timerAttack < data.cd)
		{
			timerAttack += Time.deltaTime;
			print("<color=red>AttackTimer :" + timerAttack + "</color>");
		}
		else
		{
			ani.SetTrigger(parameterAttack);
			timerAttack = 0;
		}
	}
}
