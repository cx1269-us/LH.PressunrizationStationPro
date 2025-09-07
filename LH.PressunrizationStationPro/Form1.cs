using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using xbd.s7netplus;

namespace LH.PressunrizationStationPro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // 实例化PanelDragger，传入当前窗口和顶部面板
            new PanelDragger(this, TopPanel);
            //PLC连接
            PLCconnect();

        }
        private s7NetLib siemens = null;
        //连接PLC功能
        private void PLCconnect()
        {
            // 初始化通讯类
            siemens = new s7NetLib(CpuType.S71200, "plc.xbdswj.cn", 0, 0);
            var result = siemens.connect();
            if (result != null)
            {
                ////【1】读取单个字节
                //var data = siemens.ReadVariable("DB1.DBD04");
                //if (data.IsSuccess)
                //{
                //    MessageBox.Show(Convert.ToUInt32(data.Content).ConvertToFloat().ToString());
                //}

                //【2】批量读取字节数组
                //var data2 = siemens.ReadByteArray(DataType.DataBlock, 1,0,20);
                //if (data2.IsSuccess)
                //{
                //    MessageBox.Show(BitConverter.ToString(data2.Content));
                //}

                //【4】写入单个变量
                siemens.WriteVariable("DB1.DBX100.0", true);
                Thread.Sleep(100);
                siemens.WriteVariable("DB1.DBX100.0", false);

                //【3】读取类对象
                var data3 = siemens.ReadClass<plcData>(1, 0);
                if (data3.IsSuccess)
                {
                    this.label333.Text = data3.Content.TempIn1.ToString("f2");
                    this.xbdPump1.IsRun = data3.Content.InPump1State;

                }



            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        //private void label12_Click(object sender, EventArgs e)
        //{

        //}

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void xbdWave1_Load(object sender, EventArgs e)
        {

        }

        private void xbdPump1_Load(object sender, EventArgs e)
        {

        }

        public class plcData
        {
            public bool InPump1State { get; set; }
            public bool inPump2State { get; set; }
            public bool circlePumpistate { get; set; }
            public bool circlePump2State { get; set; }
            public bool Valvelnstate { get; set; }
            public bool ValveOutstate { get; set; }
            public bool SysRunState { get; set; }
            public bool SysAlarmState { get; set; }
            public byte[] SpareState { get; set; } = new byte[2];
            public float PressureIn { get; set; }
            public float Pressureout { get; set; }
            public float TempIn1 { get; set; }
            public float TempIn2 { get; set; }
            public float Tempout { get; set; }
            public float PressureTank1 { get; set; }
            public float PressureTank2 { get; set; }
            public float LevelTank1 { get; set; }
            public float LevelTank2 { get; set; }
            public float PressureTankOut { get; set; }
            public byte[] SpareVariable { get; set; } = new byte[56];
            public bool InPumpistart { get; set; }
            public bool InPumpistop { get; set; }
            public bool inPump2start { get; set; }
            public bool inPump2Stop { get; set; }
            public bool circlePumpistart { get; set; }
            public bool circlePumpistop { get; set; }
            public bool circlePump2start { get; set; }
            public bool circlePump2Stop { get; set; }
            public bool Valvelnopen { get; set; }
            public bool Valvelnclose { get; set; }
            public bool Valveoutopen { get; set; }
            public bool ValveQutclose { get; set; }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //退出系统
            Application.Exit();

        }
    }

}
