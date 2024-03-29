﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crawler.Model
{
    /// <summary>
    /// 属性类
    /// </summary>
    public class UrlStruct : INotifyPropertyChanged
    {
        private int id;
        /// <summary>
        /// 编号
        /// </summary>
        public int Id
        {
            get { return id; }
            set
            {
                id = value;
                RaiseChange("Id");
            }
        }

        private string link;
        /// <summary>
        /// 链接
        /// </summary>
        public string Link
        {
            get { return link; }
            set
            {
                link = value;
                RaiseChange("Link");
            }
        }

        private string iamgeName;
        /// <summary>
        /// 图片名
        /// </summary>
        public string IamgeName
        {
            get { return iamgeName; }
            set
            {
                iamgeName = value;
                RaiseChange("Title");
            }
        }

        private string status;
        /// <summary>
        /// 状态
        /// </summary>
        public string Status
        {
            get { return status; }
            set
            {
                status = value;
                RaiseChange("Status");
            }
        }

        /// <summary>
        /// 获取属性改变事件
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// 属性改变时需要做出的反应
        /// </summary>
        /// <param name="property"></param>
        public void RaiseChange(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(property));
            }
        }
    }
}
