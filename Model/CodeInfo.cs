using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 代码信息
    /// </summary>
    [Serializable]
    public partial class CodeInfo
    {
        public CodeInfo()
        { }
        #region Model
        private int _id;
        private string _type;
        private string _childtype = "";
        private string _name = "";
        private string _description = "";
        private string _code = "";
        /// <summary>
        /// 
        /// </summary>
        public int Id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 分类：Html,Css,C#...
        /// </summary>
        public string Type
        {
            set { _type = value; }
            get { return _type; }
        }
        /// <summary>
        /// 分类子集：EasyUI,Layer...
        /// </summary>
        public string ChildType
        {
            set { _childtype = value; }
            get { return _childtype; }
        }
        /// <summary>
        /// 简单标题说明
        /// </summary>
        public string Name
        {
            set { _name = value; }
            get { return _name; }
        }
        /// <summary>
        /// 描述信息，对标题的解释
        /// </summary>
        public string Description
        {
            set { _description = value; }
            get { return _description; }
        }
        /// <summary>
        /// 代码
        /// </summary>
        public string Code
        {
            set { _code = value; }
            get { return _code; }
        }
        #endregion Model

    }
}
