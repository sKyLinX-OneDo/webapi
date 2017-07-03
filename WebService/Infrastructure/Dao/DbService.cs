﻿using Infrastructure.Common;
using Infrastructure.Tool;
using SqlSugar;
using System;

namespace Infrastructure.Dao
{
    /// <summary>
    ///数据访问层
    /// </summary>
    public class DbService : IDisposable
    {
        private SqlSugarClient _db;
        public DbService()
        {
            _db = DbConfig.GetDbInstance();
        }

        /// <summary>
        /// 服务命令
        /// </summary>
        /// <typeparam name="Outsourcing">外包对象</typeparam>
        /// <param name="func"></param>
        public void Command<Outsourcing>(Action<Outsourcing> func) where Outsourcing : class, new() 
        {
            try
            {
                var o = new Outsourcing();
                func(o);
                o = null;//及时释放对象 
                //_db 会在http请求结束前执行 dispose 
            }
            catch (Exception ex)
            {
                //在这里可以处理所有controller的异常
                //获错误写入日志
                WriteExMessage(ex);
                throw ex;
            }
        }

        /// <summary>
        /// 服务命令(使用Sql)
        /// </summary>
        /// <typeparam name="Outsourcing">外包对象</typeparam>
        /// <param name="func"></param>
        public void Command<Outsourcing>(Action<SqlSugarClient, Outsourcing> func) where Outsourcing : class, new() 
        {
            try
            {
                var o = new Outsourcing();
                func(_db, o);
                o = null;//及时释放对象 
                //_db 会在http请求结束前执行 dispose 
            }
            catch (Exception ex)
            {
                //在这里可以处理所有controller的异常
                //获错误写入日志
                WriteExMessage(ex);
                throw ex;
            }
        }

        /// <summary>
        /// 服务命令(使用接口)
        /// </summary>
        /// <typeparam name="Outsourcing">外包对象</typeparam>
        /// <typeparam name="Api">接口</typeparam>
        /// <param name="func"></param>
        public void Command<Outsourcing,Api>(Action<Outsourcing,RestApi<Api>> func) where Outsourcing : class, new() where Api:class,new()
        {
            try
            {
                var o = new Outsourcing();
                var api = new RestApi<Api>();
                func(o, api);
                o = null;//及时释放对象 
                //_db 会在http请求结束前执行 dispose 
            }
            catch (Exception ex)
            {
                //在这里可以处理所有controller的异常
                //获错误写入日志
                WriteExMessage(ex);
                throw ex;
            }
        }

        /// <summary>
        /// 将错误信息写入日志
        /// </summary>
        /// <param name="ex"></param>
        private static void WriteExMessage(Exception ex)
        {
            CommonMethod.WirteExp(ex);
        }

        public void Dispose()
        {
            if (_db != null)
            {
                _db.Dispose();
            }
        }
    }
}