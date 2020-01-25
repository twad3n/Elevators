using Elevators.Models;
using Elevators.Models.Repositories;
using Elevators.Views;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevators.Presenters
{
    public class OperatorPresenter
    {

        private IKernel _kernel;
        private IMainView _view;
        private IOperatorService _service;
        private Settings _settings;

        public OperatorPresenter(IKernel kernel, IMainView view, IOperatorService service, Settings settings)
        {
            _kernel = kernel;
            _view = view;
            _service = service;
            _settings = settings;

           
        }

    }
}
