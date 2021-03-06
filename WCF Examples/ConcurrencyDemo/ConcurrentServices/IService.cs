﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ConcurrentServices
{
    [ServiceContract(CallbackContract = typeof(ICallback))]
    public interface IService
    {
        [OperationContract(IsOneWay = true)]
        //[OperationContract]
        void Process(int id);
    }
}
