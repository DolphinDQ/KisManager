using Caliburn.Micro;
using KisManager.Dal.Kis;
using KisManager.EventArgs;
using KisManager.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KisManager.ViewModels
{
    public abstract class TabModulsBase : Screen, IModule
    {
        public bool CanMultiCreate { get; set; } = false;

        public TabModulsBase(IKisLogin login, IEventAggregator eventAggregator)
        {
            DisplayName = GetType().Name;
            EventAggregator = eventAggregator;
            //Login = login;

        }

        //protected override async void OnViewAttached(object view, object context)
        //{
        //    base.OnViewAttached(view, context);
        //    await Task.Factory.StartNew(() =>
        //    {
        //        try
        //        {
        //            Loading = true;
        //            if (Login.CheckLogin())
        //            {
        //                Context = new KisContext(Login.GetConnectionString());
        //                OnContextLoad();
        //            }
        //            else
        //            {
        //                Close();
        //            }
        //        }
        //        catch (Exception e)
        //        {
        //            Close(EvtTabCloseReson.Error, e.Message);
        //        }
        //        finally
        //        {
        //            Loading = false;
        //        }

        //    });
        //}

        //protected virtual void OnContextLoad() { }

        public bool Loading { get; set; } = false;

        public IEventAggregator EventAggregator { get; }
        public IKisLogin Login { get; }
        //public KisContext Context { get; private set; }

        public void Close(EvtTabCloseReson reson = EvtTabCloseReson.None, string message = null)
        {
            EventAggregator.PublishOnBackgroundThread(new EvtTabClose() { Tab = this, Reason = reson, Message = message });
        }

        //public override void TryClose(bool? dialogResult = null)
        //{
        //    base.TryClose(dialogResult);
        //    try
        //    {
        //        Context.Dispose();
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //}
    }
}
