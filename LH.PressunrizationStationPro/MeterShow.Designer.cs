
namespace LH.PressunrizationStationPro
{
    partial class MeterShow
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_paramName = new System.Windows.Forms.Label();
            this.lbl_paramValue = new System.Windows.Forms.Label();
            this.meter_Param2 = new xbd.ControlLib.xbdAnalogMeter();
            this.SuspendLayout();
            // 
            // lbl_paramName
            // 
            this.lbl_paramName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_paramName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_paramName.Font = new System.Drawing.Font("微软雅黑", 13F);
            this.lbl_paramName.ForeColor = System.Drawing.Color.White;
            this.lbl_paramName.Location = new System.Drawing.Point(0, 143);
            this.lbl_paramName.Name = "lbl_paramName";
            this.lbl_paramName.Size = new System.Drawing.Size(147, 25);
            this.lbl_paramName.TabIndex = 0;
            this.lbl_paramName.Text = "出水管温度";
            this.lbl_paramName.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lbl_paramValue
            // 
            this.lbl_paramValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbl_paramValue.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.lbl_paramValue.Location = new System.Drawing.Point(29, 119);
            this.lbl_paramValue.Name = "lbl_paramValue";
            this.lbl_paramValue.Size = new System.Drawing.Size(87, 24);
            this.lbl_paramValue.TabIndex = 2;
            this.lbl_paramValue.Text = "0.0°C";
            this.lbl_paramValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // meter_Param2
            // 
            this.meter_Param2.BodyColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(45)))));
            this.meter_Param2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.meter_Param2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.meter_Param2.Location = new System.Drawing.Point(0, 0);
            this.meter_Param2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.meter_Param2.MaxValue = 10D;
            this.meter_Param2.MinValue = 0D;
            this.meter_Param2.Name = "meter_Param2";
            this.meter_Param2.NeedleColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.meter_Param2.Renderer = null;
            this.meter_Param2.ScaleColor = System.Drawing.Color.White;
            this.meter_Param2.ScaleDivisions = 11;
            this.meter_Param2.ScaleSubDivisions = 4;
            this.meter_Param2.Size = new System.Drawing.Size(147, 143);
            this.meter_Param2.TabIndex = 1;
            this.meter_Param2.Value = 0D;
            this.meter_Param2.ViewGlass = false;
            // 
            // MeterShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(45)))));
            this.Controls.Add(this.lbl_paramValue);
            this.Controls.Add(this.meter_Param2);
            this.Controls.Add(this.lbl_paramName);
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MeterShow";
            this.Size = new System.Drawing.Size(147, 168);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_paramName;
        private System.Windows.Forms.Label lbl_paramValue;
        private xbd.ControlLib.xbdAnalogMeter meter_Param2;
    }
}
