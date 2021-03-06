
using System;
using System.Collections.Generic;
using System.Linq;

internal static partial class SdkInfo
{
    public static IEnumerable<Tuple<string, string, string>> ApiInfo_SubscriptionsAdminClient
    {
        get
        {
            return new Tuple<string, string, string>[]
            {
                new Tuple<string, string, string>("Subscriptions.Admin", "AcquiredPlans", "2015-11-01"),
                new Tuple<string, string, string>("Subscriptions.Admin", "DelegatedProviderOffers", "2015-11-01"),
                new Tuple<string, string, string>("Subscriptions.Admin", "DelegatedProviders", "2015-11-01"),
                new Tuple<string, string, string>("Subscriptions.Admin", "DirectoryTenants", "2015-11-01"),
                new Tuple<string, string, string>("Subscriptions.Admin", "Locations", "2015-11-01"),
                new Tuple<string, string, string>("Subscriptions.Admin", "OfferDelegations", "2015-11-01"),
                new Tuple<string, string, string>("Subscriptions.Admin", "Offers", "2015-11-01"),
                new Tuple<string, string, string>("Subscriptions.Admin", "Operations", "2015-11-01"),
                new Tuple<string, string, string>("Subscriptions.Admin", "Plans", "2015-11-01"),
                new Tuple<string, string, string>("Subscriptions.Admin", "Quotas", "2015-11-01"),
                new Tuple<string, string, string>("Subscriptions.Admin", "RestoreData", "2015-11-01"),
                new Tuple<string, string, string>("Subscriptions.Admin", "Subscriptions", "2015-11-01"),
                new Tuple<string, string, string>("Subscriptions.Admin", "UpdateEncryption", "2015-11-01"),
            }.AsEnumerable();
        }
    }
}
