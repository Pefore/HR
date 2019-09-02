using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tool;

namespace DAL
{
   public class SqlDBHelper
    {
        //连接对象
        static SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=HR;User ID=li;Password=li");
        /// <summary>
        /// 查询单个值，适用于聚合函数
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="sp"></param>
        /// <returns></returns>
        public static object DGZ(string sql, params SqlParameter[] sp)
        {
            object i =null;
            SqlCommand com = new SqlCommand(sql, con);
            if (sp != null)
            {
                com.Parameters.AddRange(sp);
            }
            try
            {
                con.Open();
                i =(object)com.ExecuteScalar();
            }
            catch (Exception ex)
            {
            }
            finally
            {
                con.Close();
            }
            return i;
        }
        /// <summary>
        /// 数据库增删改
        /// </summary>
        public static bool ADU(string sql, params SqlParameter[] sp)
        {
            int i = 0;
            SqlCommand com = new SqlCommand(sql, con);
            if (sp != null)
            {
                com.Parameters.AddRange(sp);
            }
            try
            {
                con.Open();
                i = com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                
            }
            finally
            {

                con.Close();
            }
            return i > 0;
        }
        /// <summary>
        /// 数据库查询，返回一张表
        /// </summary>
        /// <returns></returns>
        public static DataTable table(string sql, params SqlParameter[] sp)
        {
            SqlDataAdapter sda = new SqlDataAdapter(sql, con);
            if (sp != null)
            {
                sda.SelectCommand.Parameters.AddRange(sp);
            }
            DataTable dt = new DataTable();
            try
            {
                sda.Fill(dt);
            }
            catch (Exception ex)
            {
              string s=ex.Message;
            }
            finally
            {
                con.Close();
            }
            return dt;
        }
        /// <summary>
        /// 数据库查询，一行一行返回
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="sp"></param>
        /// <returns></returns>
        public static SqlDataReader read(string sql, params SqlParameter[] sp)
        {
            SqlCommand com = new SqlCommand(sql, con);
            SqlDataReader r = null;
            if (sp != null)
            {
                com.Parameters.AddRange(sp);
            }
            try
            {
                con.Open();
                r = com.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {
                
            }
            return r;
        }
        /// <summary>
        /// 用于分页
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="ps"></param>
        /// <returns></returns>
        public static DataTable SelectFenYe(string sql, params SqlParameter[] ps)
        {
            //读取学生表的信息
            SqlDataAdapter ad = new SqlDataAdapter(sql,con);
            if (ps != null)
            {
                //把参数对象放入命令对象中
                ad.SelectCommand.Parameters.AddRange(ps);
            }
            //执行的是存储过程
            ad.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            try
            {
                ad.Fill(dt);
            }
            catch (Exception ex)
            {
               
            }
            return dt;
        }
    }
}
