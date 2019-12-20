﻿using Elevators.Presenters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevators.Views
{
    public interface ISettingsView: IBasicView
    {
        event Delegates.GoToScenario GoToScenario;
        void Save();
        void Discard();
        void Import();
        void Export();

        void Show();
    }
}
