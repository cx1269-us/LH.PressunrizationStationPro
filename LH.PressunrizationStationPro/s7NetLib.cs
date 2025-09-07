using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xbd.DataConvertLib;
using xbd.s7netplus;
using DataType = xbd.s7netplus.DataType;

namespace LH.PressunrizationStationPro
{
    class s7NetLib
    {
        /// <summary>
        /// 通讯类
        /// 

        private Plc siemens;
        private static object _lockObj = new object();
        //属性
        public CpuType CpuType { get; set; }
        public string IP { get; set; }
        public short Rack { get; set; }

        public short Slot { get; set; }

        //无参构造函数
        public s7NetLib()
        {

        }
        //有参构造函数
        public s7NetLib(CpuType cpuType, string ip, short rack, short slot)
        {
            this.CpuType = cpuType;
            this.IP = ip;
            this.Rack = rack;
            this.Slot = slot;
        }
        /// <summary>
        /// 连接PLC
        /// </summary>
        /// <returns></returns>
        public OperateResult connect()
        {
            try
            {

                if (siemens != null && siemens.IsConnected)
                {
                    siemens.Close();
                    siemens = null;
                }
                siemens = new Plc(CpuType, IP, Rack, Slot);
                siemens.Open();
                return OperateResult.CreateSuccessResult();
            }
            catch (Exception ex)
            {

                return OperateResult.CreateFailResult(ex.Message);
            }

        }

        /// <summary>
        /// 断开PLC连接
        /// </summary>
        /// <returns></returns>
        public OperateResult disconncet()
        {
            try
            {

                if (siemens != null && siemens.IsConnected)
                {
                    siemens.Close();
                    siemens = null;
                }
                return OperateResult.CreateSuccessResult();
            }
            catch (Exception ex)
            {
                return OperateResult.CreateFailResult(ex.Message);
            }
        }
        /// <summary>
        /// 读取字节数组
        /// </summary>
        /// <param name="dataType"></param>
        /// <param name="db"></param>
        /// <param name="start"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public OperateResult<byte[]> ReadByteArray(DataType dataType, int db, int start, int count)
        {
            if (this.siemens != null && siemens.IsConnected)
            {
                try
                {
                    lock (_lockObj)
                    {
                        siemens.ReadBytes(dataType, db, start, count);
                        return OperateResult.CreateSuccessResult(siemens.ReadBytes(dataType, db, start, count));
                    }

                }
                catch (Exception ex)
                {

                    return OperateResult.CreateFailResult<byte[]>(ex.Message);
                }

            }
            else
            {
                return OperateResult.CreateFailResult<byte[]>("PLC未连接");
            }

        }

        /// <summary>
        /// 读取单个变量
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="varAddress"></param>
        /// <returns></returns>
        public OperateResult<object> ReadVariable(string varAddress)
        {
            if (this.siemens != null && siemens.IsConnected)
            {
                try
                {
                    lock (_lockObj)
                    {
                        return OperateResult.CreateSuccessResult(siemens.Read(varAddress));
                    }
                }
                catch (Exception ex)
                {
                    return OperateResult.CreateFailResult<object>(ex.Message);
                }
            }
            else
            {
                return OperateResult.CreateFailResult<object>("PLC未连接");
            }
        }

        /// <summary>
        /// 读取类
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="db"></param>
        /// <param name="start"></param>
        /// <returns></returns>
        public OperateResult<T> ReadClass<T>(int db, int start) where T : class
        {
            if (this.siemens != null && siemens.IsConnected)
            {
                try
                {
                    lock (_lockObj)
                    {

                        return OperateResult.CreateSuccessResult(siemens.ReadClass<T>(db, start));
                    }
                }
                catch (Exception ex)
                {
                    return OperateResult.CreateFailResult<T>(ex.Message);
                }
            }
            else
            {
                return OperateResult.CreateFailResult<T>("PLC未连接");
            }
        }

        /// <summary>
        /// 写入单个变量
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="varAddress"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public OperateResult WriteVariable<T>(string varAddress, T value)
        {
            if (this.siemens != null && siemens.IsConnected)
            {
                try
                {
                    lock (_lockObj)
                    {
                        siemens.Write(varAddress, value);
                        return OperateResult.CreateSuccessResult();
                    }
                }
                catch (Exception ex)
                {
                    return OperateResult.CreateFailResult(ex.Message);
                }
            }
            else
            {
                return OperateResult.CreateFailResult("PLC未连接");
            }
        }
        /// <summary>
        ///写入数组
        /// </summary>
        /// <param name="dataType"></param>
        /// <param name="db"></param>
        /// <param name="start"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public OperateResult WriteByteArray(DataType dataType, int db, int start, byte[] value)
        {
            if (this.siemens != null && siemens.IsConnected)
            {
                try
                {
                    lock (_lockObj)
                    {
                        siemens.WriteBytes(dataType, db, start, value);
                        return OperateResult.CreateSuccessResult();
                    }
                }
                catch (Exception ex)
                {
                    return OperateResult.CreateFailResult(ex.Message);
                }
            }
            else
            {
                return OperateResult.CreateFailResult("PLC未连接");
            }
        }


    }
}
