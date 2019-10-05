using Autofac;
using Autofac.Integration.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TodoListData.Context;
using TodoListData.Repository;

namespace TodoList.Web.App_Start
{
    public class ContainerConfig
    {
        internal static void RegisterContainer()
        {
            var builder = new ContainerBuilder();

            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            //builder.RegisterType<TodoListData.Repository.TodoListData>().As<TodoListData>().InstancePerRequest();
            builder.RegisterType<TodoListContext>().InstancePerRequest();
        }
    }
}