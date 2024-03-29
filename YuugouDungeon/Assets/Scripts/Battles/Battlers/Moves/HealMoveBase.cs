using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static SEManager;

//MoveBase(Name)を継承した「回復」技の基礎データ
[CreateAssetMenu]
public class HealMoveBase : MoveBase
{
    [SerializeField] int healPoint;     // 回復量
    [SerializeField] int magicPoint;    // 消費魔力

    //外部で取得できるように
    public int HealPoint { get => healPoint; }
    public int MagicPoint { get => magicPoint; }

    //関数のオーバーライド
    public override string RunMoveResult(BattleUnit sourcerUnit, BattleUnit targetUnit)
    {
        //int型でmagicPointを受け取る
        sourcerUnit.Battler.Magic(magicPoint);
        //int型でhealPointを受け取る
        sourcerUnit.Battler.Heal(healPoint);
        //回復SE再生
        SEManager.Instance.PlaySE(SESoundData.SE.Heal);
        //回復したダイアログを返す
        return $"{sourcerUnit.Battler.Base.Name}の{Name}!\n{sourcerUnit.Battler.Base.Name}はHPを{healPoint}回復した！";
    }
}
