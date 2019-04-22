using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
namespace DllTest
{
    public partial class Form1 : Form
    {
        MesService.Tools service = new MesService.Tools();
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 测试检查用户、密码、资源代码是否正确
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn1_Click(object sender, EventArgs e)
        {
            try
            {
                string Msg = "";
                
                bool flag = service.CheckUserAndResourcePassed(this.UserName.Text, this.ResourceCode.Text, this.PassWord.Text, out Msg);
                if (!flag)
                {
                    MessageBox.Show(Msg);
                }
                else
                {
                    MessageBox.Show("调用成功");
                }
            }
            catch (Exception ex)
            {
                
                 MessageBox.Show(ex.Message);
            }
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            try
            {
                string Msg = "";
                
                bool flag = service.CheckRoutePassed(this.SnText.Text, this.ResourceCode.Text, out Msg);
                if (!flag)
                {
                    MessageBox.Show(Msg);
                }
                else
                {
                    MessageBox.Show("调用成功");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string Msg = "";
                //bool flag = service.CheckRoutePassed(this.SnText.Text, this.ResourceCode.Text, out Msg);
                if(string.IsNullOrEmpty(NGCode.Text))
                {
                    bool flag = service.SetMobileData(this.SnText.Text, this.ResourceCode.Text, "admin", "OK", "", "", out Msg);
                    if (!flag)
                    {
                        MessageBox.Show(Msg);
                    }
                    else
                    {
                        MessageBox.Show("调用成功");
                    }
                }
                else
                {
                    string _ngcode = NGCode.Text.Trim();
                    string _ngtext = NGText.Text.Trim();
                    bool flag = service.SetMobileData(this.SnText.Text, this.ResourceCode.Text, "admin", "NG", _ngcode, _ngtext, out Msg);
                    if (!flag)
                    {
                        MessageBox.Show(Msg);
                    }
                    else
                    {
                        MessageBox.Show("调用成功");
                    }
                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string Msg = "";
                //bool flag = service.CheckRoutePassed(this.SnText.Text, this.ResourceCode.Text, out Msg);
                bool flag = service.SetAttachment(this.ResourceCode.Text, this.FJType.Text, this.SnText.Text, this.FJText.Text, "admin", out Msg);
                if (!flag)
                {
                    MessageBox.Show(Msg);
                }
                else
                {
                    MessageBox.Show("调用成功");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string Msg = "";
                string outFjTxt = "";
                //bool flag = service.CheckRoutePassed(this.SnText.Text, this.ResourceCode.Text, out Msg);
                bool flag = service.GetAttachment(this.ResourceCode.Text, this.FJType.Text, this.SnText.Text, out outFjTxt, out Msg);
                if (!flag)
                {
                    MessageBox.Show(Msg);
                }
                else
                {
                    MessageBox.Show("调用成功");
                    listBox1.Items.Add("获取附件编码：" + outFjTxt);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string Msg = "";
                string mo = "";
                //bool flag = service.CheckRoutePassed(this.SnText.Text, this.ResourceCode.Text, out Msg);\
                bool flag = service.GetMoBysn(this.SnText.Text, this.ResourceCode.Text, out mo, out Msg);
                if (!flag)
                {
                    MessageBox.Show(Msg);
                }
                else
                {
                    MessageBox.Show("调用成功");
                    listBox1.Items.Add("获取工单：" + mo);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                string Msg = "";
                string mo = "";
                //bool flag = service.CheckRoutePassed(this.SnText.Text, this.ResourceCode.Text, out Msg);\

                bool flag = service.CheckSN(this.SnText.Text, this.PROC_NO.Text, out Msg);
                if (!flag)
                {
                    MessageBox.Show(Msg);
                }
                else
                {
                    MessageBox.Show("调用成功");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                string Msg = "";
                string str = ArrayIn.Text;

                bool flag = service.CheckRoutePassed_Plus(this.SnText.Text, this.ResourceCode.Text, str, out Msg);
                
                if (!flag)
                {
                    MessageBox.Show(Msg);
                }
                else
                {
                    MessageBox.Show("调用成功");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                string Msg = "";
                string str = ArrayIn.Text;

                
                bool flag = service.PrintSN(this.SnText.Text, model.Text,1, out Msg);

                if (!flag)
                {
                    MessageBox.Show(Msg);
                }
                else
                {
                    MessageBox.Show("调用成功");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                string Msg = "",oAllCode="";
                //bool flag = service.CheckRoutePassed(this.SnText.Text, this.ResourceCode.Text, out Msg);

                bool flag = service.SetMobileData("HMB384000001", "A301_GX049", "603411", "OK", null, null, out Msg);
                //bool flag = service.GetAllCode("A302_GX048", "HMB384000003", "HMB384000003", out oAllCode, out Msg);
                if (!flag)
                {
                    MessageBox.Show(Msg);
                }
                else
                {
                    MessageBox.Show("调用成功");
                }
                

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public string RunCmd(string cmd)
        {
            Process proc = null;
            proc = new Process();
            proc.StartInfo.CreateNoWindow = true;
            proc.StartInfo.FileName = "cmd.exe";
            proc.StartInfo.UseShellExecute = false;
            proc.StartInfo.RedirectStandardError = true;
            proc.StartInfo.RedirectStandardInput = true;
            proc.StartInfo.RedirectStandardOutput = true;
            proc.Start();
            proc.StandardInput.WriteLine(cmd + "&exit");
           // string outStr = proc.StandardOutput.ReadToEnd();
            string outStr = "";
            StreamReader reader = proc.StandardOutput;
            string line=reader.ReadLine();
            while (!reader.EndOfStream)
            {                
                line = reader.ReadLine();
                outStr = line;
            }

            proc.Close();
            return outStr;
        }


        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                string str = cmdTxt.Text + " " + cmdParaTxt.Text;
                
                string output = RunCmd(str);
                

                listBox1.Items.Add(output);
            }catch(Exception ex)
            {
                listBox1.Items.Add("异常："+ex.Message);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                string Msg = "", oAllCode = "";
                //bool flag = service.CheckRoutePassed(this.SnText.Text, this.ResourceCode.Text, out Msg);
                bool flag = service.UploadFile(ResourceCode.Text, "model", filedir.Text, SnText.Text, DateTime.Now.ToString(), System.IO.Path.GetFileName(filedir.Text), "OK", out Msg);
                //bool flag = service.SetMobileData("HMB384000001", "A301_GX049", "603411", "OK", null, null, out Msg);
                //bool flag = service.GetAllCode("A302_GX048", "HMB384000003", "HMB384000003", out oAllCode, out Msg);
                if (!flag)
                {
                    MessageBox.Show(Msg);
                }
                else
                {
                    MessageBox.Show("调用成功");
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                string Msg = "";
                string str ="";;

                bool flag = service.GetPolycomInfo(SnText.Text,out str,out Msg);

                if (!flag)
                {
                    MessageBox.Show(Msg);
                }
                else
                {

                    MessageBox.Show("调用成功,返回code："+str);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
