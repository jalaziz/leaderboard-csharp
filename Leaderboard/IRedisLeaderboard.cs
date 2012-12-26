﻿using System;
using System.Collections.Generic;

namespace Leaderboard
{
    public interface IRedisLeaderboard<T> : ILeaderboard<T>
    {
        void ExpireLeaderboard(int seconds);
        void ExpireLeaderboard(string leaderboardName, int seconds);
        void ExpireLeaderboardAt(DateTime time);
        void ExpireLeaderboardAt(string leaderboardName, DateTime time);

        void MergeLeaderboards(string destination, IEnumerable<string> keys, Aggregate aggregate = Aggregate.SUM);
        void IntersectLeaderboards(string destination, IEnumerable<string> keys, Aggregate aggregate = Aggregate.SUM);
    }
}
