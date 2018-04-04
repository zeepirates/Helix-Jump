using System;
using UnityEngine.Purchasing;

public interface IPurchaseDelegate
{
    void OnInitializeFailure(InitializationFailureReason reason);
    void OnPurchaseComplete(string productId);
    void OnPurchaseFailure(string productId, PurchaseFailureReason reason);
}

