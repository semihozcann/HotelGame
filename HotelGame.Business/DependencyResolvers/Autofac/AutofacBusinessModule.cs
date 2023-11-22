using Autofac;
using HotelGame.Business.Abstract;
using HotelGame.Business.Concrete;
using HotelGame.DataAccess.Abstract;
using HotelGame.DataAccess.Concrete.EntityFramework;
using HotelGame.DataAccess.Concrete.EntityFramework.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelGame.Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<HotelGameContext>().As<DbContext>().SingleInstance();

            builder.RegisterType<EfHotelTypeDal>().As<IHotelTypeDal>();
            builder.RegisterType<HotelTypeManager>().As<IHotelTypeService>();

        }
    }
}
