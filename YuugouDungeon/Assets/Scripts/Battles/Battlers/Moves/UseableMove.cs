using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class UseableMove
{
    //使えるわざのリスト生成
    [SerializeField] MoveBase moveBase;

    public MoveBase MoveBase { get => moveBase; }
}
