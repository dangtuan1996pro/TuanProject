﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication1.Model
{
    public class PHIEUXUAT :_ModelBase
    {
        public string MaPX { get { return GetSTR(0); } set { SetData(0, value); } }
        public string NgayXuat { get { return GetSTR(1); } set { SetData(1, value); } }
        public string MaNV { get { return GetSTR(2); } set { SetData(2, value); } }
       
        public override void Setup()
        {
            MaxFields = 3;
            ValueData = new object[MaxFields];
        }

        public override Type GetDataType()
        {
            return this.GetType();
        }
    }
}
