using UnityEngine;
using System.Collections;

public class Boss
{
    private int hp = 100;   // 体力
    private int power = 25; // 攻撃力
    private int mp = 53;
    private int mpForMagicUse = 5;  // 魔法を使うために消費する MP

    // 攻撃用の関数
    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    // 防御用の関数
    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        // 残りhpを減らす
        this.hp -= damage;
    }

    public void Magic()
    {
        if (mp >= mpForMagicUse)
        {
            mp -= mpForMagicUse;
            Debug.LogFormat("魔法攻撃をした。残りMPは {0} 。", mp);
        }
        else
        {
            Debug.Log("MPが足りないため魔法が使えない。");
        }
    }
}

public class Test : MonoBehaviour
{
    int numberOfTimesForMagic = 10; // 連続で魔法を使う回数

    void Start()
    {
        // Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss();

        // 攻撃用の関数を呼び出す
        lastboss.Attack();
        // 防御用の関数を呼び出す
        lastboss.Defence(3);

        for (int i = 0; i < numberOfTimesForMagic; i++)
        {
            lastboss.Magic();
        }

        lastboss.Magic();
    }
}