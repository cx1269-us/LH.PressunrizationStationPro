using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LH.PressunrizationStationPro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            new PanelDragger(this,TopPanel);
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


    }



    //public class PanelDragger
    //{
    //    private Form _targetForm;      // 要拖动的窗口
    //    private Control _dragPanel;    // 用于拖动的顶部面板
    //    private bool _isDragging;      // 是否正在拖动
    //    private int _mouseOffsetX;     // 鼠标X偏移量
    //    private int _mouseOffsetY;     // 鼠标Y偏移量

    //    // 构造函数：需要传入窗口和顶部面板
    //    public PanelDragger(Form targetForm, Control dragPanel)
    //    {
    //        _targetForm = targetForm ?? throw new ArgumentNullException(nameof(targetForm));
    //        _dragPanel = dragPanel ?? throw new ArgumentNullException(nameof(dragPanel));

    //        // 绑定面板的鼠标事件
    //        _dragPanel.MouseDown += DragPanel_MouseDown;
    //        _dragPanel.MouseMove += DragPanel_MouseMove;
    //        _dragPanel.MouseUp += DragPanel_MouseUp;

    //        // 可选：设置面板鼠标样式为手型，提示可拖动
    //        _dragPanel.Cursor = Cursors.Hand;
    //    }

    //    // 鼠标按下事件：开始拖动
    //    private void DragPanel_MouseDown(object sender, MouseEventArgs e)
    //    {
    //        // 只处理左键点击
    //        if (e.Button == MouseButtons.Left)
    //        {
    //            _isDragging = true;
    //            // 记录鼠标在面板中的位置（偏移量）
    //            _mouseOffsetX = e.X;
    //            _mouseOffsetY = e.Y;
    //        }
    //    }

    //    // 鼠标移动事件：处理拖动
    //    private void DragPanel_MouseMove(object sender, MouseEventArgs e)
    //    {
    //        if (_isDragging)
    //        {
    //            // 计算新的窗口位置
    //            Point newLocation = _targetForm.PointToScreen(new Point(e.X, e.Y));
    //            newLocation.X -= _mouseOffsetX;
    //            newLocation.Y -= _mouseOffsetY;

    //            // 限制窗口不超出屏幕范围（可选）
    //            newLocation.X = Math.Max(0, newLocation.X);
    //            newLocation.Y = Math.Max(0, newLocation.Y);

    //            // 更新窗口位置
    //            _targetForm.Location = newLocation;
    //        }
    //    }

    //    // 鼠标释放事件：结束拖动
    //    private void DragPanel_MouseUp(object sender, MouseEventArgs e)
    //    {
    //        if (e.Button == MouseButtons.Left)
    //        {
    //            _isDragging = false;
    //        }
    //    }
    //}

}
