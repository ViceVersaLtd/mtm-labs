using System.Collections.Generic;
using Microsoft.Marketplace.SaaS.Models;

namespace PublisherPortal.ViewModels.Home;

public class OperationsViewModel
{
    public Microsoft.Marketplace.SaaS.Models.SaaSOperation OperationStatus { get; set; }
    public IReadOnlyList<Microsoft.Marketplace.SaaS.Models.SaaSOperation> SubscriptionOperations { get; set; }
    public Subscription Subscription { get; set; }
}