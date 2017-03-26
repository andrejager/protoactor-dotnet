﻿// -----------------------------------------------------------------------
//   <copyright file="IClusterProvider.cs" company="Asynkron HB">
//       Copyright (C) 2015-2017 Asynkron HB All rights reserved
//   </copyright>
// -----------------------------------------------------------------------
namespace Proto.Cluster
{
    public interface IClusterProvider
    {
        void RegisterMember(string clusterName, string h, int p, string[] kinds);
        void MonitorMemberStatusChanges();
    }
}