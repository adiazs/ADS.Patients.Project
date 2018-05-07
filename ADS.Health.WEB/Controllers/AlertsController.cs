using ADS.Health.WEB.Libraries;
using ADS.Health.WEB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ADS.Health.WEB.Controllers
{
    public class AlertsController : Controller
    {
        public void Success(string message, bool dismissable = false)
        {
            AddAlert(Messages.Success, message, dismissable);
        }

        public void Information(string message, bool dismissable = false)
        {
            AddAlert(Messages.Information, message, dismissable);
        }

        public void Warning(string message, bool dismissable = false)
        {
            AddAlert(Messages.Warning, message, dismissable);
        }

        public void Error(string message, bool dismissable = false)
        {
            AddAlert(Messages.Error, message, dismissable);
        }

        private void AddAlert(string alertStyle, string message, bool dismissable)
        {
            var alerts = TempData.ContainsKey(Alert.TempDataKey)
                ? (List<Alert>)TempData[Alert.TempDataKey]
                : new List<Alert>();

            alerts.Add(new Alert
            {
                AlertStyle = alertStyle,
                Message = message,
                Dismissable = dismissable
            });

            TempData[Alert.TempDataKey] = alerts;
        }


    }
}