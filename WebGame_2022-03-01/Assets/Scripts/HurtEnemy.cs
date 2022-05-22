
using UnityEngine;

namespace GG
{
	public class HurtEnemy : HurtSystem
	{
		[SerializeField, Header("敵人資料")]
		private DataEnemy data;
		
		private void Start()
		{
			hp = data.hp;
		}
	}
  
}
