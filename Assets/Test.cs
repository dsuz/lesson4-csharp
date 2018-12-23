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
        /* ===== 課題 ===== */

        Debug.Log("課題");

        // 要素の個数が5の、int型の配列arrayを宣言して好きな値で初期化してください
        int[] array = { 1, 3, 5, 7, 9 };

        // for文を使い、配列の各要素の値を順番に表示してください
        Debug.Log("for文を使い、配列の各要素の値を順番に表示する。");
        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }

        // for文を使い、配列の各要素の値を逆順に表示してください
        Debug.Log("for文を使い、配列の各要素の値を逆順に表示する。");
        for (int i = array.Length - 1; i > -1; i--)
        {
            Debug.Log(array[i]);
        }

        /* ===== 発展課題 ===== */

        // Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss();

        // 攻撃用の関数を呼び出す
        lastboss.Attack();
        // 防御用の関数を呼び出す
        lastboss.Defence(3);

        Debug.Log("発展課題");

        for (int i = 0; i < numberOfTimesForMagic; i++)
        {
            lastboss.Magic();
        }

        lastboss.Magic();
    }
}