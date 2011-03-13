using Ninject;
using Ninject.Modules;
using NHibernate;
using System.Collections;
using Ninject.Activation;
using System.Web;
using System.Diagnostics;
using ClassTracker.Data;

namespace mPSOR.Dependencies
{
    /// <summary>
    /// Ninject module to define bindings and handle NHibernate session generation
    /// </summary>
    public class NHibernateModule : NinjectModule
    {
        internal const string SESSION_KEY = "NHibernate.ISession";

        /// <summary>
        /// Builds NHibernate session factory (Configuration) and binds it to a constant
        /// so that all objects requiring the factory can use this original copy. Load()
        /// then completes bindings.
        /// </summary>
        public override void Load()
        {
            Configuration cfg = new Configuration();
            cfg.Configure();

            Bind<Configuration>().ToConstant(cfg);
            Bind<ISession>().ToMethod(x => GetRequestSession(x));
            Bind<IRepository>().To<NHibernateRepository>();
        }

        /// <summary>
        /// Checks for an existing NHibernate session in the user's context. If it exists, it is returned,
        /// otherwise, a new session is created.
        /// </summary>
        /// <param name="Ctx"></param>
        /// <returns>NHibernate session.</returns>
        private ISession GetRequestSession(IContext Ctx)
        {
            IDictionary Dict = HttpContext.Current.Items;
            ISession Session;
            if (!Dict.Contains(SESSION_KEY))
            {
                // Create an NHibernate session for this request
                Debug.WriteLine("Creating an NHibernate session");
                Session = Ctx.Kernel.Get<Configuration>().OpenSession();
                Dict.Add(SESSION_KEY, Session);
            }
            else
            {
                // Re-use the NHibernate session for this request
                Debug.WriteLine("Re-using the NHibernate session");
                Session = (ISession)Dict[SESSION_KEY];
            }
            return Session;
        }
    }
}
