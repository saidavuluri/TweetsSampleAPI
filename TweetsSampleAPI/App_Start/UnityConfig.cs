using System.Web.Http;
using System.Web.Mvc;
using TweetsSampleAPI.Repository;
using Unity;
using Unity.WebApi;

namespace TweetsSampleAPI
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<ITweetRepository, TweetRepository>();
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}