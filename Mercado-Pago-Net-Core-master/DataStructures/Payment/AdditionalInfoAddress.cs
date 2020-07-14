﻿// Decompiled with JetBrains decompiler
// Type: MercadoPago.DataStructures.Payment.AdditionalInfoAddress
// Assembly: MercadoPago, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0C24A3BA-51C0-4EAB-8180-D4EA12994FDF
// Assembly location: C:\Users\Laucha\source\repos\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\MercadoPago.dll

using System.ComponentModel.DataAnnotations;

namespace MercadoPago.DataStructures.Payment
{
  public struct AdditionalInfoAddress
  {
    [StringLength(256)]
    private string _street_name;
    private int _street_number;
    [StringLength(256)]
    private string _zip_code;

    public string StreetName
    {
      get
      {
        return this._street_name;
      }
      set
      {
        this._street_name = value;
      }
    }

    public int StreetNumber
    {
      get
      {
        return this._street_number;
      }
      set
      {
        this._street_number = value;
      }
    }

    public string ZipCode
    {
      get
      {
        return this._zip_code;
      }
      set
      {
        this._zip_code = value;
      }
    }
  }
}
