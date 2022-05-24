
using UnityEngine;

namespace GG
{
	public class HurtEnemy : HurtSystem
	{
		[SerializeField, Header("敵人資料")]
		private DataEnemy data;
		[SerializeField, Header("畫布傷害數值")]
		private GameObject goCanvasHurt;
		[SerializeField, Header("經驗值道具")]
		private GameObject goExp;
		
		private string parameterDead = "觸發死亡";
		private Animator ani;
		private EnemySystem enemySystem;
		
		private void Awake()
		{
			ani = GetComponent<Animator>();
			enemySystem = GetComponent<EnemySystem>();
			
			hp = data.hp;
		}
		public override void GetHurt(float damage)
		{
			base.GetHurt(damage);
			
			GameObject temp = Instantiate(goCanvasHurt, transform.position, Quaternion.identity);
			temp.GetComponent<HurtNumberEffect>().UpdateDamage(damage);
		}
		
		protected override void Dead()
		{
			base.Dead();
			
			ani.SetTrigger(parameterDead);
			
			enemySystem.enabled = false;
			GetComponent<Collider2D>().enabled = false;
			Destroy(gameObject, 2);
			
			DropExp();
		}
		
		private void DropExp()
		{
			float randwom = Random.value;
			
			if(randwom <= data.expDropProbability)
			{
				GameObject tempExp = Instantiate(goExp, transform.position, Quaternion.identity);
				tempExp.AddComponent<Exp>().typeExp = data.typeExp;
			}
		}
	}
  
}
