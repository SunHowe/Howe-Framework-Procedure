using System;
using System.Collections.Generic;
using CatLib.Container;
using HoweFramework.Base;
using HoweFramework.Fsm;
using HoweFramework.Procedure.Exceptions;

namespace HoweFramework.Procedure.Implements
{
    public class ProcedureServiceImpl : IProcedureService, IService
    {
        [Inject]
        public IFsmService fsmService { get; set; }

        public ProcedureBase procedure => _fsm?.activeState as ProcedureBase;

        private IFsm _fsm;

        public void Initialize()
        {
        }

        public void Dispose()
        {
            if (_fsm == null)
                return;
            
            fsmService.Destroy(_fsm);
            _fsm = null;
        }

        public bool IsProcedure(Type procedureType)
        {
            return _fsm != null && _fsm.IsState(procedureType);
        }

        public bool HasProcedure(Type procedureType)
        {
            return _fsm != null && _fsm.HasState(procedureType);
        }

        public void Launch(Type entryProcedureType, ProcedureBase[] procedures)
        {
            if (_fsm != null)
                throw new ProcedureAlreadyLaunchException();

            // ReSharper disable once CoVariantArrayConversion
            _fsm = fsmService.Spawn(procedures);
            fsmService.Start(_fsm, entryProcedureType);
        }
    }
}