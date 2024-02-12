using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class BattlerBase : ScriptableObject
{
    //Battler�̊�b�f�[�^
    //���O
    [SerializeField] new private string name;
    //HP
    [SerializeField] private int maxHp;
    //MP
    [SerializeField] private int maxMp;
    //�U����
    [SerializeField] private int attack;
    // �g�p�ł���킴���X�g
    [SerializeField] private List<UseableMove> useableMove; 

    //�ʃt�@�C������擾�ł���悤��
    public string Name { get => name;}
    public int MaxHP { get => maxHp;}
    public int AT { get => attack;}
    public int MaxMP { get => maxMp;}
    public List<UseableMove> UseableMove { get => useableMove; }
}
