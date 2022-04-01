using UnityEngine;

namespace GG
{
	public class WeaponSystem : MonoBehaviour
	{
		[SerializeField, Header("Weapon")]
		private DataWeapon dataWeapon;
		
		private float timer;
		
		private void OnDrawGizmos()
		{
			Gizmos.color = new Color(1, 0, 0, 0.5f);
			
			for (int i = 0; i < dataWeapon.v3SpawnPoint.Length; i++)
			{
				Gizmos.DrawSphere(transform.position + dataWeapon.v3SpawnPoint[i], 0.1f);
			}
		}
		
		private void Update()
		{
			SpawnWeapon();
		}
		
		private void SpawnWeapon()
		{
			timer += Time.deltaTime;
			
			//print("Time : " + timer);
			
			if (timer >= dataWeapon.interval)
			{
				print("generate Weapon");
				timer = 0;
			}
		}
	}
}