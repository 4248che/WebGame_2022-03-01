using UnityEngine;

namespace GG
{
	public class Weapon : MonoBehaviour
	{
		[HideInInspector]
		public float attack;
		
		private void OnCollisionEnter20(Collision2D collision)
		{
			if (collision.gameObject.tag == "敵人")
			{
				//print("<color=red>打到敵人 :" + collision.gameObject + "</color>");
				collision.gameObject.GetComponent<HurtSystem>().GetHurt(attack);
			}
		}
	}
}

