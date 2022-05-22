using UnityEngine;
using System.Collections;

namespace GG
{
	public class HurtNumberEffect : MonoBehaviour
	{
		private CanvasGroup group;
		
		private void Awake()
		{
			group = GetComponent<CanvasGroup>();
			
			StartCoroutine(Test());
		}
		
		
		
		private IEnumerator Test()
		{
			print("第一行");
			
			yield return new WaitForSeconds(2);
			
			print("兩秒後 第二行");
		}
	}
}
