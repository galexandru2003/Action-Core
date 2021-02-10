using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Action.Core
{
    public interface IAction
    {
        Task Execute();
    }
}
