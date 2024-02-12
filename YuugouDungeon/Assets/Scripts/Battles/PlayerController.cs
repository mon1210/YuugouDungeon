using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] Battler battler;

    public Battler Battler { get => battler;}

    void Awake()
    {
        battler.Init();
    }

}
