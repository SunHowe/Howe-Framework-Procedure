using System;

namespace HoweFramework.Procedure
{
    /// <summary>
    /// 流程服务接口
    /// </summary>
    public interface IProcedureService
    {
        /// <summary>
        /// 当前所处的流程
        /// </summary>
        ProcedureBase procedure { get; }

        /// <summary>
        /// 判断当前是否是指定流程
        /// </summary>
        bool IsProcedure(Type procedureType);

        /// <summary>
        /// 是否存在指定流程
        /// </summary>
        bool HasProcedure(Type procedureType);

        /// <summary>
        /// 加载指定流程集合，启动指定默认入口流程
        /// </summary>
        void Launch(Type entryProcedureType, ProcedureBase[] procedures);
    }
}