using DomainModel;
using Huilv.Core.ADO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    /// <summary>
    /// 代码操作类
    /// </summary>
    public class CodeInfoService
    {
        private static CodeInfoService _instance = new CodeInfoService();
        public static CodeInfoService Instance
        {
            get { return _instance; }
        }
        /// <summary>
        /// 添加代码信息
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public int AddCode(CodeInfo code)
        {
            //验证代码合法性
            try
            {
                VerifyCode(code);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //录入代码信息
            var dc = new DataControl();
            code.Id = dc.Add<Model.CodeInfo, int>("Id", code);

            if (code.Id == 0) throw new Exception("添加代码信息出错");

            return code.Id;
        }
        /// <summary>
        /// 更新代码信息
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public bool UpdateCode(CodeInfo code)
        {
            //验证代码合法性
            try
            {
                VerifyCode(code);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //更新代码信息
            var dc = new DataControl();
            var flag = dc.Update<Model.CodeInfo>("Id", code);
            if (!flag) throw new Exception("更新代码信息出错");

            return flag;
        }

        /// <summary>
        /// 获取所有列表
        /// </summary>
        /// <returns></returns>
        public List<CodeInfo> GetAllList()
        {
            var dc = new DataControl();

            return dc.GetListBySql<CodeInfo>("select * from CodeInfo order by Type", null)?? new List<CodeInfo>();
        }

        /// <summary>
        /// 验证代码是否合法
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public bool VerifyCode(CodeInfo code)
        {
            //验证参数
            if (string.IsNullOrEmpty(code.Type)) throw new Exception("请填写分类");
            if (string.IsNullOrEmpty(code.Name)) throw new Exception("请填写标题");
            if (string.IsNullOrEmpty(code.Code)) throw new Exception("请输入代码");

            return true;
        }

    }
}
