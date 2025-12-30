using System.Text.Json.Serialization;

namespace ECommerceApp.Models;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum RefundMethod
{
    Original,   //Regund back to the original payment method
    Paypal,
    Stripe,
    BankTransfer,
    Manual
}