
using System.Reflection;
using System.Web.Mvc;
using System.Web.Routing;
using NHibernate;
using Ninject;
using Ninject.Web.Mvc;
using System.Web;
using System.Diagnostics;
using ClassTracker.Dependencies;


namespace ClassTracker
{
    public class MvcApplication : NinjectHttpApplication
    {
        ISessionFactory sessionFactory;

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute("Default", "{controller}/{action}/{id}", new { controller = "Home", action = "Index", id = "" });

        }

        protected override void OnApplicationStarted()
        {
            base.OnApplicationStarted();
            AreaRegistration.RegisterAllAreas();
            RegisterRoutes(RouteTable.Routes);

            // Use Ninject to register all of our controllers.
            // Reportedly only for MVC1
            // RegisterAllControllersIn(Assembly.GetExecutingAssembly());
        }

        protected void MvcApplication_BeginRequest()
        {
            sessionFactory.OpenSession();
        }

        private void MvcApplication_EndRequest(object sender, System.EventArgs e)
        {
            if (Context.Items.Contains(NHibernateModule.SESSION_KEY))
            {
                Debug.WriteLine("Disposing the NHibernate session");
                NHibernate.ISession Session = (NHibernate.ISession)Context.Items[NHibernateModule.SESSION_KEY];
                Session.Flush();
                Session.Dispose();
                Context.Items[NHibernateModule.SESSION_KEY] = null;
            }
        }

        protected override IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());
            return kernel;
        }
    }
}

