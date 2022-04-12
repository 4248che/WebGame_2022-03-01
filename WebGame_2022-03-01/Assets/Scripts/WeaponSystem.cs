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
        private void Start()
        {
			Physics2D.IgnoreLayerCollision(3, 6);
			Physics2D.IgnoreLayerCollision(6, 6);
			Physics2D.IgnoreLayerCollision(6, 7);
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

				int random = Random.Range(0, dataWeapon.v3SpawnPoint.Length);

				print("generate Weapon");
				timer = 0;

				Vector3 pos = transform.position + dataWeapon.v3SpawnPoint[random];

				GameObject temp = Instantiate(dataWeapon.goWeapon, pos, Quaternion.identity);

				temp.GetComponent<Rigidbody2D>().AddForce(dataWeapon.v3Direction * dataWeapon.speed);

				timer = 0;
			}
		}
	}
}