using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LH.PressunrizationStationPro
{
    public partial class MeterShow : UserControl
    {
        public MeterShow()
        {
            InitializeComponent();
        }
        private string paramName = "出水管温度";
        [Browsable(true)]
        [Category("自定义属性")]
        [Description("参数名称")]
        public string MyProperty
        {
            get { return paramName; }
            set
            {
                paramName = value;
                this.lbl_paramName.Text = paramName;
            }
        }
        private float paramValue = 0.0f;
        [Browsable(true)]
        [Category("自定义属性")]
        [Description("设置或获取变量数值")]
        public float ParamValue
        {
            get { return paramValue; }
            set
            {
                //变化更新
                if (paramValue != value)
                {
                    paramValue = value;
                    this.lbl_paramValue.Text = paramValue.ToString("0.00") + " " + unit;
                }

            }
        }

        private string unit = "C";
        [Browsable(true)]
        [Category("自定义属性")]
        [Description("设置或获取变量单位")]
        public string Unit
        {
            get { return unit; }
            set
            {
                unit = value;
                this.lbl_paramValue.Text = paramValue.ToString("0.00") + " " + unit;
            }
        }

        private float meterMax = 100.0f;
        [Browsable(true)]
        [Category("自定义属性")]
        [Description("设置表盘最大值")]
        public float MeterMax
        {
            get { return meterMax; }
            set { meterMax = value; 
            this.meter_Param2.MaxValue = meterMax;
            }
        }
        private float meterMin=0.0f;
        [Browsable(true)]
        [Category("自定义属性")]
        [Description("设置表盘最小值")]
        public float MeterMin
        {
            get { return meterMin; }
            set
            {
                meterMin = value;
                this.meter_Param2.MinValue = meterMin;
            }
        }


    }
}
