using System.Web.Mvc;
using Unity;
using Unity.Mvc5;
using ServicesCL;

namespace UsingUnityDI
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<IInstitutionService, InstitutionService>();
            container.RegisterType<ICourseService, CourseService>();
            
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}