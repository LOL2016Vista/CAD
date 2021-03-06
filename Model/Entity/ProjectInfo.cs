﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.Entity
{   
    /// <summary>
    /// 对应“工程信息”窗体上的数据
    /// </summary>
    public static class ProjectInfo
    {
        public static int Pro_Id { get; set; }//工程Id
        public static string Pro_Name { get; set; }// 工程名称
        public static string Pro_Type { get; set; }//工程类型
        public static string Con_Province { get; set; }//建设省份
        public static string Con_City { get; set; }//建设城市
        public static string Unit { get; set; }//施工单位
        public static string Con_Unit { get; set; }//建设单位
        public static string Sup_Unit { get; set; }//监理单位
        public static double Con_Area { get; set; }//建筑面积
        public static double Con_Height { get; set; }//建筑高度
        public static string Des_Unit { get; set; }//设计单位

        //一个将实体重置的方法
        public static void Clear()
        {
            Pro_Id = 0;
            Pro_Name = null;
            Pro_Type = null;
            Con_Province = null;
            Con_City = null;
            Unit = null;
            Con_Unit = null;
            Sup_Unit = null;
            Con_Area = 0.0;
            Con_Height = 0.0;
            Des_Unit = null;
        }

        public static object[] GetValArray()
        {
            object[] arrayToPrint = new object[]{   
                                                    Pro_Id,
                                                    Pro_Name,
                                                    Pro_Type,
                                                    Con_Province ,
                                                    Con_City ,
                                                    Unit ,
                                                    Con_Unit ,
                                                    Sup_Unit ,
                                                    Con_Area ,
                                                    Con_Height,
                                                    Des_Unit ,

            };
            return arrayToPrint;
        }

        public static string[] GetKeyArray()
        {
            string[] keys = new string[]{
                                           "@Pro_Id@",
                                           "@Pro_Name@",
                                           "@Pro_Type@",
                                           "@Con_Province@" ,
                                           "@Con_City@" ,
                                           "@Unit@" ,
                                           "@Con_Unit@" ,
                                           "@Sup_Unit@" ,
                                           "@Con_Area@" ,
                                           "@Con_Height@",
                                           "@Des_Unit@" ,
            };
            return keys;
        }
    }
    
}
