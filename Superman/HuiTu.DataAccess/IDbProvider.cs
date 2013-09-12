//-----------------------------------------------------------------------
// <copyright file="IDbProvider.cs" company="汇图网络科技有限公司">
//     Copyright (c) 汇图网络科技有限公司. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System;
using System.Data;
using System.Data.Common;

namespace HuiTu.DataAccess
{
    public interface IDbProvider
    {
        /// <summary>
        /// 返回DbProviderFactory实例
        /// </summary>
        /// <returns></returns>
        DbProviderFactory Instance();

        /// <summary>
        /// 检索SQL参数信息并填充
        /// </summary>
        /// <param name="command"></param>
        void DeriveParameters(IDbCommand command);

        /// <summary>
        /// 创建SQL参数
        /// </summary>
        /// <param name="paramName"></param>
        /// <param name="dbType"></param>
        /// <param name="size"></param>
        /// <returns></returns>
        DbParameter MakeParam(string paramName, DbType dbType, Int32 size);

        /// <summary>
        /// 是否支持全文搜索
        /// </summary>
        /// <returns></returns>
        bool IsFullTextSearchEnabled();

        /// <summary>
        /// 是否支持压缩数据库
        /// </summary>
        /// <returns></returns>
        bool IsCompactDatabase();

        /// <summary>
        /// 是否支持备份数据库
        /// </summary>
        /// <returns></returns>
        bool IsBackupDatabase();

        /// <summary>
        /// 返回刚插入记录的自增ID值, 如不支持则为""
        /// </summary>
        /// <returns></returns>
        string GetLastIdSql();

        /// <summary>
        /// 是否支持数据库优化
        /// </summary>
        /// <returns></returns>
        bool IsDbOptimize();

        /// <summary>
        /// 是否支持数据库收缩
        /// </summary>
        /// <returns></returns>
        bool IsShrinkData();

        /// <summary>
        /// 是否支持存储过程
        /// </summary>
        /// <returns></returns>
        bool IsStoreProc();
    }
}
