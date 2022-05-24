using UnityEngine;
using UnityEngine.UI;

namespace GG
{
	public class LevelManager : MonoBehaviour
	{
		private int lv;
		private int exp;
		private int expMax;
		
		[SerializeField, Header("經驗值")]
		private Image imgExp;
		[SerializeField, Header("等級")]
		private Text textlv;
		[SerializeField, Header("經驗值需求表")]
		private int[] expsNeed;
		
		[ContextMenu("Setting Exps Need")]
		private void SettingExpsNeed()
		{
			expsNeed = new int[99];
			
			for (int i = 0; i < expsNeed.Length; i++)
			{
				expsNeed[i] = (i + 1) * 100;
			}
		}
		
		public void GetExp(int getExp)
		{
			exp += getExp;
			expMax = expsNeed[lv - 1];
			
			while (exp >= expMax)
			{
				lv++;
				exp -= expMax;
				expMax = expsNeed[lv - 1];
			}
			
			imgExp.fillAmount = (float)exp / (float)expMax;
			textlv.text = "Lv " + lv;
		}
	}

}
