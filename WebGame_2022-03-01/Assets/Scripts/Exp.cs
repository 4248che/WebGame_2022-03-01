using UnityEngine;

namespace GG
{
	public class Exp : MonoBehaviour
	{
		public TypeExp typeExp;
		
		private float rangeToPlayer = 2;
		private float speedToPlayer = 3.5f;
		private LayerMask layerPlayer = 1 << 3;
		private float destroyDistance = 0.5f;
		
		private Color colorSmall = new Color(0.5f, 0.3f, 0.8f);
		private Color colorMiddle = new Color(0.2f, 0.8f, 0.1f);
		private Color colorBig = new Color(0.8f, 0.3f, 0.2f);
		
		private Transform traPlayer;
		private SpriteRenderer spr;
		private int exp;
		
		private void Awake()
		{
			spr = GetComponent<SpriteRenderer>();
			traPlayer = GameObject.Find("刺客").transform;
		}
		
		private void Start()
		{
			SettingExp();
		}
		
		private void Update()
		{
			CheckPlayerInRange();
		}
		
		private void OnDrawGizmos()
		{
			Gizmos.color = new Color(1, 0, 0.2f, 0.2f);
			Gizmos.DrawSphere(transform.position, rangeToPlayer);
		}
		
		private void SettingExp()
		{
			switch(typeExp)
			{
				case TypeExp.small:
				    spr.color = colorSmall;
					exp = 20;
					break;
				case TypeExp.middle:
				    spr.color = colorMiddle;
					exp = 100;
					break;
				case TypeExp.big:
				    spr.color = colorBig;
					exp = 200;
					break;	
			}
		}
		
		private void CheckPlayerInRange()
		{
			Collider2D hit = Physics2D.OverlapCircle(transform.position, rangeToPlayer, layerPlayer);
			
			if(hit)
			{
				FlyToPlayer();
			}
		}
		
		private void FlyToPlayer()
		{
			Vector3 posExp = transform.position;
			Vector3 posPlayer = traPlayer.position;
			
			posExp = Vector3.Lerp(posExp, posPlayer, speedToPlayer * Time.deltaTime);
			
			transform.position = posExp;
			
			float dis = Vector3.Distance(posExp, posPlayer);
			
			if(dis <= destroyDistance)
			{
				Destroy(gameObject);
			}
		}
	}
}
