using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

namespace New_TJ_Tutors_System
{
    public class backup
    {
        /// <summary>
        /// 执行Cmd命令
        /// </summary>
        /// <param name="workingDirectory">要启动的进程的目录</param>
        /// <param name="command">要执行的命令</param>
        public static void StartCmd(String workingDirectory, String command)
        {
            using (Process p = new Process())
            {
                p.StartInfo.FileName = "cmd.exe"; 
                p.StartInfo.WorkingDirectory = workingDirectory; 
                p.StartInfo.UseShellExecute = false; 
                p.StartInfo.RedirectStandardInput = true; 
                p.StartInfo.RedirectStandardOutput = true; 
                p.StartInfo.RedirectStandardError = true; 
                p.StartInfo.CreateNoWindow = true;                          //p.EnableRaisingEvents = true;                　　　　　　　　　　p.Start();                　　　　　　　　　　p.StandardInput.WriteLine(command);                　　　　　　　　　　p.StandardInput.WriteLine("exit");                　　　　　　　　　　//p.StandardInput.Flush();
                p.BeginOutputReadLine(); 
                string error = p.StandardError.ReadToEnd(); 
                p.WaitForExit(); 
                if (!string.IsNullOrEmpty(error) && (error.ToLower().Contains("error"))) 
                    throw new System.Data.DataException(error);
            }
        }
        /// <summary>
        /// 数据库备份
        /// </summary>
        /// <param name="ip">数据库IP</param>
        /// <param name="port">数据库端口</param>
        /// <param name="dbName">数据库名</param>
        /// <param name="userName">用户名</param>
        /// <param name="userPsw">用户密码</param>
        /// <param name="filepath">本分路径</param>
        /// <param name="characterset">数据库数据格式</param>
        public void Backup(string filepath)
        {
            string characterset = "utf8";
            //创建进程对象   
            Process proc = new Process();
            //调用dos窗口
            proc.StartInfo.FileName = "cmd.exe";
            //不显示窗体
            proc.StartInfo.CreateNoWindow = true;
            //设置dos窗口的目录路径，这里就是自己安装mysql的bin目录（我们的mysqldump.exe和mysql.exe所在目录）
            proc.StartInfo.WorkingDirectory = commondb.mysql_path;
            //允许输入流
            proc.StartInfo.UseShellExecute = false;
            proc.StartInfo.RedirectStandardInput = true;
            proc.StartInfo.RedirectStandardOutput = true;
            proc.StartInfo.RedirectStandardError = true;
            //执行
            proc.Start();
            string command = string.Format("mysqldump --quick --host=" + commondb.host + " --default-character-set=" + characterset + 
                " --lock-tables --verbose  --force --port=" + "3306" + " --user=" + commondb.userid + " --password=" + commondb.password + 
                " " + commondb.database + " -r \"{0}\"", filepath);

            //登陆数据库，这里的内容和我们直接使用dos窗口备份数据库的方式一致，前面是数据库登陆信息，后面是备份路径
            proc.StandardInput.WriteLine(command);
            proc.Close();



        }
        /// <summary>
        /// 数据库还原
        /// </summary>
        /// <param name="ip">数据库IP</param>
        /// <param name="port">数据库端口</param>
        /// <param name="dbName">数据库名</param>
        /// <param name="userName">用户名</param>
        /// <param name="userPsw">用户密码</param>
        /// <param name="filepath">本分路径</param>
        /// <param name="characterset">数据库数据格式</param>
        public void Restore(string filepath)
        {
            //创建进程对象   
            Process proc = new Process();
            //调用dos窗口
            proc.StartInfo.FileName = "cmd.exe";
            //不显示窗体
            proc.StartInfo.CreateNoWindow = true;
            //设置dos窗口的目录路径，这里就是自己安装mysql的bin目录
            proc.StartInfo.WorkingDirectory = commondb.mysql_path;
            //允许输入流
            proc.StartInfo.UseShellExecute = false;
            proc.StartInfo.RedirectStandardInput = true;
            proc.StartInfo.RedirectStandardOutput = true;
            proc.StartInfo.RedirectStandardError = true;
            //执行
            proc.Start();
            //登陆数据库，这里的内容和我们直接使用dos窗口登陆数据库的方式一致
            string connection = "mysql -h" + commondb.host + " -u" + commondb.userid + " -p" + commondb.password;
            string database = "use " + commondb.database;
            proc.StandardInput.WriteLine(connection);
            //切换到我们需要操作的数据库
            proc.StandardInput.WriteLine(database);
            //先前备份的sql脚本文件读取
            StreamReader sr = new StreamReader(filepath);
            while (!sr.EndOfStream)
            {
                //使用WriteLine方法把脚本一行一行进行写入并且执行
                proc.StandardInput.WriteLine(sr.ReadLine());
            }
            sr.Close();
            proc.Close();


        }
    }
}
