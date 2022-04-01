using UnityEngine;

namespace GG
{
	public class TopDownController : MonoBehaviour
	{
		#region CC
		[SerializeField, Header("speed"), Range(0, 100)]
		private float speed = 10.5f;
		private string parameterRun = "Idle";
		private string parameterDead = "roll";
		private Animator ani;
		private Rigidbody2D rig;
		private float h;
		private float v;
		#endregion
		
		#region CC1
		private void Awake()
		{
			//print("OG~");
			
			ani = GetComponent<Animator>();
			rig = GetComponent<Rigidbody2D>();
		}
		
		private void Update()
		{
			// print("Dbug~");
			
			GetInput();
			Move();
		}
		#endregion
		
		#region CC2
		private void GetInput()
		{
			h = Input.GetAxis("Horizontal");
			v = Input.GetAxis("Vertical");
			
			//print("LINE : " + h );
		}
		
		private void Move()
		{
			rig.velocity = new Vector2(h,v) * speed;
			
			ani.SetBool(parameterRun, h != 0 || v !=0);
			
			transform.eulerAngles = new Vector3(0, h >= 0 ? 0 : 180, 0);
		}
		#endregion
	}

}