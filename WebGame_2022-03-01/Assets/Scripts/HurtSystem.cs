using UnityEngine;


namespace GG
{
	public class HurtSystem : MonoBehaviour
	{
		[SerializeField, Header("血量"), Range(0, 10000)]
		protected float hp = 50;
		
		
		public void GetHurt(float damage)
		{
			hp -= damage;
			print("<color=#887700>受到傷害 :" + damage + "</color>");
			
			if(hp <= 0) Dead();
		}
		
		private void Dead()
		{
			hp = 0;
			print("<color=#887700>角色死亡 :" + gameObject + "</color>");
		}
	}
}

