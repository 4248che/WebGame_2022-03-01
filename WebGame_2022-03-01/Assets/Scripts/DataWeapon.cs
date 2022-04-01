using UnityEngine;

namespace GG
{
	[CreateAssetMenu(menuName = "GG/Data Weapon", fileName = "Data Weapon")]
	public class DataWeapon : ScriptableObject
	{
		[Header("flight speed"), Range(0, 5000)]
		public float speed = 500;
		[Header("attack power"), Range(0, 100)]
		public float attack = 10;
		[Header("starting quantity"), Range(1, 10)]
		public int countStart = 1;
		[Header("big quantity"), Range(1, 20)]
		public int countMax = 3;
		[Header("interval time"), Range(0, 5)]
		public float interval = 3.5f;
		
		[Header("Generate location")]
		public Vector3[] v3SpawnPoint;
	}

}

