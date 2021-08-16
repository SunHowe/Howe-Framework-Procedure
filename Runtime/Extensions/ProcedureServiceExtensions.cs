namespace HoweFramework.Procedure.Extensions
{
    /// <summary>
    /// 流程服务拓展方法
    /// </summary>
    public static class ProcedureServiceExtensions
    {
        /// <summary>
        /// 判断当前是否是指定流程
        /// </summary>
        public static bool IsProcedure<T>(this IProcedureService procedureService) where T : ProcedureBase
        {
            return procedureService.IsProcedure(typeof(T));
        }

        /// <summary>
        /// 是否存在指定流程
        /// </summary>
        public static bool HasProcedure<T>(this IProcedureService procedureService) where T : ProcedureBase
        {
            return procedureService.HasProcedure(typeof(T));
        }

        /// <summary>
        /// 加载指定流程集合，启动指定默认入口流程
        /// </summary>
        public static void Launch<T>(this IProcedureService procedureService, ProcedureBase[] procedures) where T : ProcedureBase
        {
            procedureService.Launch(typeof(T), procedures);
        }
    }
}