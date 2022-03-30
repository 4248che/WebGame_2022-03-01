using UnityEngine;

namespace GG
{
	public class TopDownController : MonoBehaviour
	{
		#region CC
		private float speed = 10.5f;
		private string parameterRun = "";
		private string parameterDead = "";
		private Animator ani;
		private Rigidbody2D rig;
		#endregion
		
		#region CC1
		private void Awake()
		{
			print("OG~");
			
			ani = GetComponent<Animator>();
			rig = GetComponent<Rigidbody2D>();
		}
		
		private void Update()
		{
			print("Dbug~");
		}
		#endregion
		
		#region CC2
		#endregion
	}

}