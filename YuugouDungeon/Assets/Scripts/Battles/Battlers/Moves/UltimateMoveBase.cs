using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static SEManager;

//MoveBase(Name)���p�������u�Ђ����v�Z�̊�b�f�[�^
[CreateAssetMenu]
public class UltimateMoveBase : MoveBase
{
    [SerializeField] int power;         //�З�
    [SerializeField] int magicPoint;    //�����

    //�O���Ŏ擾�ł���悤��
    public int MagicPoint { get => magicPoint; }
    public int Power { get => power; }

    //�֐��̃I�[�o�[���C�h
    public override string RunMoveResult(BattleUnit sourcerUnit, BattleUnit targetUnit)
    {
        //int�^��magicPoint���󂯎��
        sourcerUnit.Battler.Magic(magicPoint);
        //int�^�Ŏ󂯎�����_���[�W���Z�b�g
        int damage = targetUnit.Battler.TakeDamage(power, sourcerUnit.Battler);
        //�K�ESE�Đ�
        SEManager.Instance.PlaySE(SESoundData.SE.Ultimate);
        //�_���[�WSE�Đ�
        SEManager.Instance.PlaySE(SESoundData.SE.Damage);
        //�_���[�W��^�����E�󂯂����O��Ԃ�
        return $"{sourcerUnit.Battler.Base.Name}�͂�������ӂ肵�ڂ����I\n�Ђ����킴�u{Name}�v�I\n{targetUnit.Battler.Base.Name}��{damage}�̃_���[�W�I";
    }
}