using UnityEngine;  // 引用 UnityEngine API Application Programer Interface 倉庫

public class Knight : MonoBehaviour
{
    // 宣告變數語法：
    // 修飾詞 變數類型 變數名稱 指定 值 結尾
    // 整數 int                    預設值 0
    // 浮點數 float                預設值 0
    // 字串 string                 預設值 空
    // 布林值 bool true 或 false   預設值 false 
    // 修飾詞：公開 public、私人 private (預設值)
    [Header("血量"), Tooltip("這是血量。")]
    public float Hp = 100;
    [Header("魔力")]
    public float Mp = 50;
    public float Atk = 20;
    [Header("走路速度"), Tooltip("不要調太高。"), Range(10, 500)]
    public float Speed = 20.5f;
    public int JumpPower = 100;

    private bool Kill100;
    private float Exp;
    private int Lv = 1;
    private int Coin;
    private string Name = "女騎士";
}
