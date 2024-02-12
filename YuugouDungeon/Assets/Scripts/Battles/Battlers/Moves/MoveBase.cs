using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//�킴�̊�b�f�[�^
[CreateAssetMenu]
public class MoveBase : ScriptableObject
{
    //���O
    [SerializeField] new string name;
    //�O���Ŏ擾�ł���悤��
    public string Name { get => name; }

    //���
    public enum SkillType
    {
        Default = -1,
        Attack,
        Magic,
        Ultimate,
    }
    //Inspecter����ݒ�ł���悤��
    [SerializeField]private SkillType moveStatus;
    public SkillType MoveStatus { get => moveStatus; }

    //���z�֐��錾
    //�_�C�A���O�\���֐�
    public virtual string RunMoveResult(BattleUnit sourcerUnit, BattleUnit targetUnit)
    {
        return "";
    }
}
