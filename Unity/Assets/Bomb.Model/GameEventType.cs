﻿namespace GameEventType
{
    /// <summary>
    /// 登录成功
    /// </summary>
    public struct LoginSuccess
    {
    }

    /// <summary>
    /// 大厅玩家信息发生改变
    /// </summary>
    public struct LobbyPlayerInfoChanged
    {
    }

    /// <summary>
    /// 进入房间成功
    /// </summary>
    public struct EnterRoomSuccess
    {
        public long RoomNum;
        public long RoomMaster;
        public int CurrentPlayerSeatIndex;
    }

    /// <summary>
    /// Player房间事件
    /// </summary>
    public struct PlayerRoomEvent
    {
        public enum ActionState
        {
            Enter,
            Exit,
            Ready
        }

        public ActionState Action;
        public int Seat;
    }

    public struct TeamChangedEvent
    {
    }

    public struct ExitRoom
    {
    }

    public struct GameStartEvent
    {
        public bool GameOver;
    }

    public struct TurnGameEvent
    {
    }

    /// <summary>
    /// 玩家出牌事件
    /// </summary>
    public struct PlayerPlayCardEvent
    {
        // 出牌错误码
        public int ErrorCode;
    }

    public struct RoundEndEvent
    {
    }
}