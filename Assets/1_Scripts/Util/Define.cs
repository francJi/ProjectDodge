using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Define
{
    public enum UIEvent
    {
        Click,
        Pressed,
        PointerDown,
        PointerUp,
    }

    public enum Scene
    {
        Unknown,
        MainScene,
        GameScene,
        JiyeonScene,
        YoungHyunScene,
        HalimScene,
        MainGameScene,
        LobbyScene,
        SelectStageScene,
        MainGameJYScene,
        HanaScene,
    }

    public enum Sound
    {
        Bgm,
        Effect,
        Speech,
        Max,
    }
}