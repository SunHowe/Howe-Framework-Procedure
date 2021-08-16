using CatLib;
using CatLib.Container;
using HoweFramework.Procedure.Implements;

namespace HoweFramework.Procedure
{
    /// <summary>
    /// 流程服务提供者
    /// </summary>
    public class ProcedureServiceProvider : ServiceProvider
    {
        public override void Register()
        {
            App.Singleton<IProcedureService, ProcedureServiceImpl>();
        }
    }
}