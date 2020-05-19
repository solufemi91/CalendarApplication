﻿using CalendarApplication.Wrapper;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CalendarApplication.Installers
{
    public class WrapperInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(
                Component.For<IAccountWrapper>().ImplementedBy<AccountWrapper>(),
                Component.For<ICalendarWrapper>().ImplementedBy<CalendarWrapper>());
        }
    }
}