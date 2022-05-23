using UnityEngine;


namespace GG
{
	public class HurtSystem : MonoBehaviour
	{
		[SerializeField, Header("血量"), Range(0, 10000)]
		protected float hp = 50;
		
		
		public virtual void GetHurt(float damage)
		{
			if (hp <= 0) return;
			
			hp -= damage;
			print("<color=#887700>受到傷害 :" + damage + "</color>");
			
			if(hp <= 0) Dead();
		}
		
		protected virtual void Dead()
		{
			hp = 0;
			print("<color=#887700>角色死亡 :" + gameObject + "</color>");
		}
	}
}

