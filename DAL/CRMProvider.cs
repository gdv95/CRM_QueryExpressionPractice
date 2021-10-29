using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using System.Net;
using System.ServiceModel.Description;
using Microsoft.Xrm.Sdk.Query;

namespace DAL
{
    public class CRMProviderNew
    {
        private static Uri organizationUri = new Uri("http://nskdccrm/alventa/xrmservices/2011/Organization.svc");
        private static Uri homeRealmUri = null;

        public static IOrganizationService getConnection()
        {
            // Учетные данные вошедшего в систему пользователя для авторизации в CRM
            ClientCredentials credentials = new ClientCredentials();
            credentials.Windows.ClientCredential = CredentialCache.DefaultNetworkCredentials;

            // Создание экземпляра класса OrganizationServiceProxy для реализации интерфейса IOrganizationService
            // и предоставления канала WCF с проверкой подлинности для службы организации.
            OrganizationServiceProxy orgProxy = new OrganizationServiceProxy(organizationUri, homeRealmUri, credentials, null);
            orgProxy.ServiceConfiguration.CurrentServiceEndpoint.Binding.CloseTimeout = new TimeSpan(1, 0, 0);
            orgProxy.ServiceConfiguration.CurrentServiceEndpoint.Binding.OpenTimeout = new TimeSpan(1, 0, 0);
            orgProxy.ServiceConfiguration.CurrentServiceEndpoint.Binding.ReceiveTimeout = new TimeSpan(1, 0, 0);
            orgProxy.ServiceConfiguration.CurrentServiceEndpoint.Binding.SendTimeout = new TimeSpan(1, 0, 0);
            orgProxy.Timeout = new TimeSpan(1, 0, 0);

            IOrganizationService organizationService = orgProxy as IOrganizationService;

            return organizationService;
        }
    }
}