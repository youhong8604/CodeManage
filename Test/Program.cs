using Huilv.Core.ADO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 测试事务
            var dc = new DataControl();

            var code = new DomainModel.CodeInfo();
            code.Type = "test"; ;
            code.ChildType = "test";
            code.Name = "测试";
            code.Description = "测试";
            code.Code = "test";

            dc.BeginTran();

            code.Id = dc.Add<Model.CodeInfo, int>("Id", code);
            code.Code = code.Id.ToString();

            dc.Add<Model.CodeInfo, int>("Id", code);
            //throw new Exception("出错了");
            dc.CombitTran();

            Console.ReadLine();
            #endregion
        }
    }
}
