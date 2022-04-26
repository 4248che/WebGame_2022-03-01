using UnityEngine;

[CreateAssetMenu(menuName = "GG/Data Enemy" , fileName = "Data Enemy")]
public class DataEnemy : ScriptableObject
{
    [Header("移動速度"), Range(0, 50)]
    public float speed = 30;
    [Header("攻擊力"), Range(0, 500)]
    public float attack = 30;
    [Header("攻擊冷卻"), Range(0, 7)]
    public float cd  = 3.5f;
    [Header("血量"), Range(0, 5000)]
    public float hp = 30;
    [Header("掉落經驗值機率"), Range(0, 1)]
    public float expDropProbability = 0.8f;
    [Header("掉落經值類型")]
    public TypeExp typeExp;
}

public enum TypeExp
{
    small, middle, big
}

