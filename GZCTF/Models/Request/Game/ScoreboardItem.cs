﻿using System.Text.Json.Serialization;

namespace CTFServer.Models.Request.Game;

public class Scoreboard
{
    /// <summary>
    /// 更新时间
    /// </summary>
    public DateTimeOffset UpdateTimeUTC = DateTimeOffset.UtcNow;
    /// <summary>
    /// 队伍信息
    /// </summary>
    public IEnumerable<ScoreboardItem> Items { get; set; } = default!;
    /// <summary>
    /// 题目信息
    /// </summary>
    public IDictionary<string, IEnumerable<ChallengeInfo>> Challenges { get; set; } = default!;
}

public class ScoreboardItem
{
    /// <summary>
    /// 队伍Id
    /// </summary>
    public int Id { get; set; }
    /// <summary>
    /// 队伍名称
    /// </summary>
    public string Name { get; set; } = string.Empty;
    /// <summary>
    /// 分数
    /// </summary>
    public int Score { get; set; }
    /// <summary>
    /// 排名
    /// </summary>
    public int Rank { get; set; }
    /// <summary>
    /// 已解出的题目数量
    /// </summary>
    public int SolvedCount { get; set; }
    /// <summary>
    /// 题目情况列表
    /// </summary>
    public IEnumerable<ChallengeItem> Challenges { get; set; } = default!;
}

public class ChallengeItem
{
    /// <summary>
    /// 题目 Id
    /// </summary>
    public int Id { get; set; }
    /// <summary>
    /// 未解出、一血、二血、三血或者其他
    /// </summary>
    [JsonPropertyName("rank")]
    public SubmissionType Type { get; set; }
}

public class ChallengeInfo
{
    /// <summary>
    /// 题目Id
    /// </summary>
    public int Id { get; set; }
    /// <summary>
    /// 题目名称
    /// </summary>
    public string Title { get; set; } = string.Empty;
    /// <summary>
    /// 题目标签
    /// </summary>
    public ChallengeTag Tag { get; set; }
    /// <summary>
    /// 题目分值
    /// </summary>
    public int Score { get; set; }
}
