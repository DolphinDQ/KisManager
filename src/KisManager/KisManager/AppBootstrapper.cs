namespace KisManager
{
    using System;
    using System.Collections.Generic;
    using Caliburn.Micro;
    using KisManager.ViewModels;
    using KisManager.Interfaces;
    using KisManager.Common;
    using KisManager.Config;

    public class AppBootstrapper : BootstrapperBase, ICreator
    {
        SimpleContainer container;

        public AppBootstrapper()
        {
            Initialize();
        }

        protected override void Configure()
        {

            container = new SimpleContainer();
            container.Instance<ICreator>(this);
            container.Singleton<IWindowManager, WindowManager>();
            container.Singleton<IEventAggregator, EventAggregator>();
            container.Singleton<IResourceProvider, ResourceProvider>();
            container.Singleton<IConfigProvider, ConfigProvider>();
#if DEBUG
            container.Singleton<IKisLogin, KisLoginDebug>();
#else
            container.Singleton<IKisLogin, KisClsLogin>();
#endif
            container.PerRequest<IShell, ShellViewModel>();
            container.PerRequest<IHome, HomeViewModel>();
            container.PerRequest<ISettings, SettingsViewModel>();
            container.PerRequest<DlgViewModel>();
            container.PerRequest<DlgAreaSalesPerformanceViewModel>();
            container.PerRequest<DlgSalesPerformanceEditViewModel>();
            container.PerRequest<IModule, TabAreaSalesPerformanceViewModel>(nameof(TabAreaSalesPerformanceViewModel));
            container.PerRequest<IModule, TabPersonalSalesPerformanceViewModel>(nameof(TabPersonalSalesPerformanceViewModel));
            container.PerRequest<IModule, TabSalesPerformanceReportViewModel>(nameof(TabSalesPerformanceReportViewModel));
            container.PerRequest<IModule, TabSetDepartmentViewModel>(nameof(TabSetDepartmentViewModel));
            container.PerRequest<IModule, TabSetEmploymentViewModel>(nameof(TabSetEmploymentViewModel));
        }

        protected override object GetInstance(Type service, string key)
        {
            return container.GetInstance(service, key);
        }

        protected override IEnumerable<object> GetAllInstances(Type service)
        {
            return container.GetAllInstances(service);
        }

        protected override void BuildUp(object instance)
        {
            container.BuildUp(instance);
        }

        protected override void OnStartup(object sender, System.Windows.StartupEventArgs e)
        {
            DisplayRootViewFor<IShell>();
        }

        public T Create<T>(string name = null) => container.GetInstance<T>(name);
    }
}