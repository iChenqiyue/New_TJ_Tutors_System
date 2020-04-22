using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace New_TJ_Tutors_System
{
    class commondb
    {
        public commondb() { }
        public static string host = "localhost";
        public static string userid = "root";
        public static string password = "chen76487591";
        public static string database = "tjtutor";
        public static string connectionstr = "server="+host+";User Id ="+userid+";password="+password+";Database="+database+";";


        public string connection()
        {
            string state;
            MySqlConnection conn = new MySqlConnection(connectionstr);
            try
            {
                conn.Open();//建立连接，可能出现异常,使用try catch语句
                state= "连接成功！";
            }
            catch (MySqlException ex)
            {
                state=ex.Message;//有错则报出错误
            }
            finally
            {
                conn.Close();//关闭通道
            }
            return state;
        }


        public int Rownum(string sql)
        {
            int i = 0;
            string mystr = connectionstr;
            //从App.config文件获取连接字符串
            MySqlConnection myconn = new MySqlConnection(connectionstr);
            myconn.ConnectionString = mystr;
            myconn.Open();
            MySqlCommand mycmd = new MySqlCommand(sql, myconn);
            MySqlDataReader myreader = mycmd.ExecuteReader();
            while (myreader.Read())//循环读取信息
                i++;
            myconn.Close();
            return i;//返回读取的行数
        }
        //****************************************************************
        //返回SELECT语句执行后唯一行的唯一字符段
        //****************************************************************
        public string Returnafield(string sql)
        {//sql参数指出SQL语句
            string fn;
            string mystr = connectionstr;
            MySqlConnection myconn = new MySqlConnection();
            myconn.ConnectionString = mystr;
            myconn.Open();
            MySqlCommand mycmd = new MySqlCommand(sql, myconn);
            MySqlDataReader myreader = mycmd.ExecuteReader();
            myreader.Read();
            fn = myreader[0].ToString().Trim();
            myconn.Close();
            return fn;//返回读取的数据
        }
        //****************************************************************
        //执行更新的SQL语句：
        //UPDATE 表名 SET 字段名 = value，字段名 = value WHERE 字段名 = value
        //DELETE FROM 表名 WHERE 字段名 = value
        //INSERT INTO 表名(字段名，字段名)values(value,value)
        //****************************************************************
        public void ExecuteNonQuery(string sql)
        {
            string mystr = connectionstr;
            MySqlConnection myconn = new MySqlConnection();
            myconn.ConnectionString = mystr;
            myconn.Open();
            MySqlCommand mycmd = new MySqlCommand(sql, myconn);
            mycmd.ExecuteNonQuery();
            myconn.Close();
        }
        //****************************************************************
        //执行SELECT语句，返回DataSet对象
        //****************************************************************
        public DataSet ExecuteQuery(string sql, string tname)
        {
            string mystr = connectionstr;
            MySqlConnection myconn = new MySqlConnection();
            myconn.ConnectionString = mystr;
            myconn.Open();
            MySqlDataAdapter myda = new MySqlDataAdapter(sql, myconn);
            DataSet myds = new DataSet();
            myda.Fill(myds, tname);
            myconn.Close();
            return myds;
        }
        //****************************************************************
        //执行SELECT语句，返回聚合函数结果
        //****************************************************************
        public string ExecuteAggregateQuery(string sql)
        {
            string jg;
            string mystr = connectionstr;
            MySqlConnection myconn = new MySqlConnection();
            myconn.ConnectionString = mystr;
            myconn.Open();
            MySqlCommand mycmd = new MySqlCommand(sql, myconn);
            mycmd.CommandText = sql;
            mycmd.Connection = myconn;
            jg = mycmd.ExecuteScalar().ToString();
            myconn.Close();
            return jg;
        }

    }
}
