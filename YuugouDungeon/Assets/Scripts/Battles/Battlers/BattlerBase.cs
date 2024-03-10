using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class BattlerBase : ScriptableObject
{
    //Battlerの基礎データ
    //名前
    [SerializeField] new private string name;
    //HP
    [SerializeField] private int maxHp;
    //MP
    [SerializeField] private int maxMp;
    //攻撃力
    [SerializeField] private int attack;
    // 使用できるわざリスト
    [SerializeField] private List<UseableMove> useableMove; 

    //別ファイルから取得できるように
    public string Name { get => name;}
    public int MaxHP { get => maxHp;}
    public int AT { get => attack;}
    public int MaxMP { get => maxMp;}
    public List<UseableMove> UseableMove { get => useableMove; }
}
