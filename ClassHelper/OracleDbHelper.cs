using System;
using System.Data;
using System.Collections.Generic;
using Oracle.ManagedDataAccess.Client;
using System.Configuration;

namespace ClassHelper
{
    public class OracleDbHelper
    {
        // 数据库连接字符串（请修改为你的真实地址）
        private static readonly string _connectionString = ConfigurationManager.ConnectionStrings["OracleConn"].ConnectionString;

        #region 查询
        /// <summary>
        /// 查询语句（不带参数）
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static DataTable ExecuteQuery(string sql)
        {
            return ExecuteQuery(sql, null);
        }
        /// <summary>
        /// 查询语句（带参数）
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static DataTable ExecuteQuery(string sql, params OracleParameter[] parameters)
        {
            DataTable dt = new DataTable();
            using (OracleConnection conn = new OracleConnection(_connectionString))
            {
                using (OracleCommand cmd = new OracleCommand(sql, conn))
                {
                    try
                    {
                        conn.Open();
                        if (parameters != null) cmd.Parameters.AddRange(parameters);
                        using (OracleDataAdapter sda = new OracleDataAdapter(cmd))
                        {
                            sda.Fill(dt);
                        }
                        return dt;
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("查询失败：" + ex.Message);
                    }
                }
            }
        }
        /// <summary>
        /// 查询语句 返回第一行第一列的值（不带参数）
        /// </summary>
        public static object ExecuteScalar(string sql)
        {
            return ExecuteScalar(sql, null);
        }
        /// <summary>
        /// 查询语句 返回第一行第一列的值（带参数）
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static object ExecuteScalar(string sql, params OracleParameter[] parameters)
        {
            using (OracleConnection conn = new OracleConnection(_connectionString))
            {
                using (OracleCommand cmd = new OracleCommand(sql, conn))
                {
                    try
                    {
                        conn.Open();
                        if (parameters != null)
                            cmd.Parameters.AddRange(parameters);

                        // 核心：只取第一行第一列
                        object result = cmd.ExecuteScalar();

                        // 如果返回null，转成DBNull.Value，避免外面判断报错
                        return result == null ? DBNull.Value : result;
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("查询单值失败：" + ex.Message);
                    }
                }
            }
        }
        #endregion

        #region 增删改
        /// <summary>
        /// 增删改执行语句 返回执行行数（不带参数）
        /// </summary>
        /// <param name="sql">语句</param>
        /// <returns></returns>
        public static int ExecuteNonQuery(string sql)
        {
            return ExecuteNonQuery(sql, null);
        }
        /// <summary>
        /// 增删改执行语句 返回执行行数（带参数）
        /// </summary>
        /// <param name="sql">语句</param>
        /// <param name="parameters">入参</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static int ExecuteNonQuery(string sql, params OracleParameter[] parameters)
        {
            using (OracleConnection conn = new OracleConnection(_connectionString))
            {
                using (OracleCommand cmd = new OracleCommand(sql, conn))
                {
                    try
                    {
                        conn.Open();
                        if (parameters != null) cmd.Parameters.AddRange(parameters);
                        return cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("执行SQL失败：" + ex.Message);
                    }
                }
            }
        }
        /// <summary>
        /// 批量执行增删改语句（不带参数）
        /// </summary>
        /// <param name="sqlList"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static int BatchExecuteNonQuery(List<string> sqlList)
        {
            using (OracleConnection conn = new OracleConnection(_connectionString))
            {
                conn.Open();
                OracleTransaction transaction = conn.BeginTransaction();
                try
                {
                    int count = 0;
                    using (OracleCommand cmd = new OracleCommand())
                    {
                        cmd.Connection = conn;
                        cmd.Transaction = transaction;

                        foreach (string sql in sqlList)
                        {
                            if (string.IsNullOrWhiteSpace(sql)) continue;
                            cmd.CommandText = sql;
                            count += cmd.ExecuteNonQuery();
                        }
                    }
                    transaction.Commit(); // 全部成功提交
                    return count;
                }
                catch (Exception ex)
                {
                    transaction.Rollback(); // 出错立即回滚
                    throw new Exception($"批量执行失败，已全部回滚：{ex.Message}");
                }
            }
        }
        /// <summary>
        /// 批量执行增删改语句（带参数）
        /// </summary>
        /// <param name="sqlParamsList"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static int BatchExecuteNonQuery(List<(string Sql, OracleParameter[] Params)> sqlParamsList)
        {
            using (OracleConnection conn = new OracleConnection(_connectionString))
            {
                conn.Open();
                OracleTransaction transaction = conn.BeginTransaction();
                try
                {
                    int count = 0;
                    using (OracleCommand cmd = new OracleCommand())
                    {
                        cmd.Connection = conn;
                        cmd.Transaction = transaction;

                        foreach (var item in sqlParamsList)
                        {
                            cmd.Parameters.Clear();
                            cmd.CommandText = item.Sql;
                            if (item.Params != null) cmd.Parameters.AddRange(item.Params);
                            count += cmd.ExecuteNonQuery();
                        }
                    }
                    transaction.Commit();
                    return count;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new Exception($"批量带参执行失败，已全部回滚：{ex.Message}");
                }
            }
        }
        #endregion

        #region 执行存储
        /// <summary>
        /// 执行一个存储过程，返回受影响行数
        /// </summary>
        /// <param name="procedureName">存储名称</param>
        /// <param name="parameters">入参</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static int ExecuteProcedure(string procedureName, params OracleParameter[] parameters)
        {
            using (OracleConnection conn = new OracleConnection(_connectionString))
            {
                using (OracleCommand cmd = new OracleCommand(procedureName, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    try
                    {
                        conn.Open();
                        if (parameters != null) cmd.Parameters.AddRange(parameters);
                        return cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("执行存储过程失败：" + ex.Message);
                    }
                }
            }
        }
        /// <summary>
        /// 批量执行存储过程
        /// </summary>
        /// <param name="procList"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static int BatchExecuteProcedure(List<(string ProcName, OracleParameter[] Params)> procList)
        {
            using (OracleConnection conn = new OracleConnection(_connectionString))
            {
                conn.Open();
                OracleTransaction transaction = conn.BeginTransaction();
                try
                {
                    int count = 0;
                    using (OracleCommand cmd = new OracleCommand())
                    {
                        cmd.Connection = conn;
                        cmd.Transaction = transaction;
                        cmd.CommandType = CommandType.StoredProcedure;

                        foreach (var item in procList)
                        {
                            cmd.Parameters.Clear();
                            cmd.CommandText = item.ProcName;
                            if (item.Params != null) cmd.Parameters.AddRange(item.Params);
                            count += cmd.ExecuteNonQuery();
                        }
                    }
                    transaction.Commit();
                    return count;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new Exception($"批量存储过程执行失败，已全部回滚：{ex.Message}");
                }
            }
        }
        #endregion
    }
}
