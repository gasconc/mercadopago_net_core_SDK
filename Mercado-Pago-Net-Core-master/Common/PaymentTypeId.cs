﻿// Decompiled with JetBrains decompiler
// Type: MercadoPago.Common.PaymentTypeId
// Assembly: MercadoPago, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0C24A3BA-51C0-4EAB-8180-D4EA12994FDF
// Assembly location: C:\Users\Laucha\source\repos\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\MercadoPago.dll

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace MercadoPago.Common
{
  [JsonConverter(typeof (StringEnumConverter))]
  public enum PaymentTypeId
  {
    account_money,
    ticket,
    bank_transfer,
    atm,
    credit_card,
    debit_card,
    prepaid_card,
  }
}
