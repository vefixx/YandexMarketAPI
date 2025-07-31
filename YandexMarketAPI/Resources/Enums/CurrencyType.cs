using System.Runtime.Serialization;

namespace YandexMarketAPI.Resources.Enums;

public enum CurrencyType
{
    [EnumMember(Value = "RUR")]
    RUR,
    [EnumMember(Value = "USD")]
    USD,
    [EnumMember(Value = "EUR")]
    EUR,
    [EnumMember(Value = "UAH")]
    UAH,
    [EnumMember(Value = "AUD")]
    AUD,
    [EnumMember(Value = "GBP")]
    GBP,
    [EnumMember(Value = "BYR")]
    BYR,
    [EnumMember(Value = "BYN")]
    BYN,
    [EnumMember(Value = "DKK")]
    DKK,
    [EnumMember(Value = "ISK")]
    ISK,
    [EnumMember(Value = "KZT")]
    KZT,
    [EnumMember(Value = "CAD")]
    CAD,
    [EnumMember(Value = "CNY")]
    CNY,
    [EnumMember(Value = "NOK")]
    NOK,
    [EnumMember(Value = "XDR")]
    XDR,
    [EnumMember(Value = "SGD")]
    SGD,
    [EnumMember(Value = "TRY")]
    TRY,
    [EnumMember(Value = "SEK")]
    SEK,
    [EnumMember(Value = "CHF")]
    CHF,
    [EnumMember(Value = "JPY")]
    JPY,
    [EnumMember(Value = "AZN")]
    AZN,
    [EnumMember(Value = "ALL")]
    ALL,
    [EnumMember(Value = "DZD")]
    DZD,
    [EnumMember(Value = "AOA")]
    AOA,
    [EnumMember(Value = "ARS")]
    ARS,
    [EnumMember(Value = "AMD")]
    AMD,
    [EnumMember(Value = "AFN")]
    AFN,
    [EnumMember(Value = "BHD")]
    BHD,
    [EnumMember(Value = "BGN")]
    BGN,
    [EnumMember(Value = "BOB")]
    BOB,
    [EnumMember(Value = "BWP")]
    BWP,
    [EnumMember(Value = "BND")]
    BND,
    [EnumMember(Value = "BRL")]
    BRL,
    [EnumMember(Value = "BIF")]
    BIF,
    [EnumMember(Value = "HUF")]
    HUF,
    [EnumMember(Value = "VEF")]
    VEF,
    [EnumMember(Value = "KPW")]
    KPW,
    [EnumMember(Value = "VND")]
    VND,
    [EnumMember(Value = "GMD")]
    GMD,
    [EnumMember(Value = "GHS")]
    GHS,
    [EnumMember(Value = "GNF")]
    GNF,
    [EnumMember(Value = "HKD")]
    HKD,
    [EnumMember(Value = "GEL")]
    GEL,
    [EnumMember(Value = "AED")]
    AED,
    [EnumMember(Value = "EGP")]
    EGP,
    [EnumMember(Value = "ZMK")]
    ZMK,
    [EnumMember(Value = "ILS")]
    ILS,
    [EnumMember(Value = "INR")]
    INR,
    [EnumMember(Value = "IDR")]
    IDR,
    [EnumMember(Value = "JOD")]
    JOD,
    [EnumMember(Value = "IQD")]
    IQD,
    [EnumMember(Value = "IRR")]
    IRR,
    [EnumMember(Value = "YER")]
    YER,
    [EnumMember(Value = "QAR")]
    QAR,
    [EnumMember(Value = "KES")]
    KES,
    [EnumMember(Value = "KGS")]
    KGS,
    [EnumMember(Value = "COP")]
    COP,
    [EnumMember(Value = "CDF")]
    CDF,
    [EnumMember(Value = "CRC")]
    CRC,
    [EnumMember(Value = "KWD")]
    KWD,
    [EnumMember(Value = "CUP")]
    CUP,
    [EnumMember(Value = "LAK")]
    LAK,
    [EnumMember(Value = "LVL")]
    LVL,
    [EnumMember(Value = "SLL")]
    SLL,
    [EnumMember(Value = "LBP")]
    LBP,
    [EnumMember(Value = "LYD")]
    LYD,
    [EnumMember(Value = "SZL")]
    SZL,
    [EnumMember(Value = "LTL")]
    LTL,
    [EnumMember(Value = "MUR")]
    MUR,
    [EnumMember(Value = "MRO")]
    MRO,
    [EnumMember(Value = "MKD")]
    MKD,
    [EnumMember(Value = "MWK")]
    MWK,
    [EnumMember(Value = "MGA")]
    MGA,
    [EnumMember(Value = "MYR")]
    MYR,
    [EnumMember(Value = "MAD")]
    MAD,
    [EnumMember(Value = "MXN")]
    MXN,
    [EnumMember(Value = "MZN")]
    MZN,
    [EnumMember(Value = "MDL")]
    MDL,
    [EnumMember(Value = "MNT")]
    MNT,
    [EnumMember(Value = "NPR")]
    NPR,
    [EnumMember(Value = "NGN")]
    NGN,
    [EnumMember(Value = "NIO")]
    NIO,
    [EnumMember(Value = "NZD")]
    NZD,
    [EnumMember(Value = "OMR")]
    OMR,
    [EnumMember(Value = "PKR")]
    PKR,
    [EnumMember(Value = "PYG")]
    PYG,
    [EnumMember(Value = "PEN")]
    PEN,
    [EnumMember(Value = "PLN")]
    PLN,
    [EnumMember(Value = "KHR")]
    KHR,
    [EnumMember(Value = "SAR")]
    SAR,
    [EnumMember(Value = "RON")]
    RON,
    [EnumMember(Value = "SCR")]
    SCR,
    [EnumMember(Value = "SYP")]
    SYP,
    [EnumMember(Value = "SKK")]
    SKK,
    [EnumMember(Value = "SOS")]
    SOS,
    [EnumMember(Value = "SDG")]
    SDG,
    [EnumMember(Value = "SRD")]
    SRD,
    [EnumMember(Value = "TJS")]
    TJS,
    [EnumMember(Value = "THB")]
    THB,
    [EnumMember(Value = "TWD")]
    TWD,
    [EnumMember(Value = "BDT")]
    BDT,
    [EnumMember(Value = "TZS")]
    TZS,
    [EnumMember(Value = "TND")]
    TND,
    [EnumMember(Value = "TMM")]
    TMM,
    [EnumMember(Value = "UGX")]
    UGX,
    [EnumMember(Value = "UZS")]
    UZS,
    [EnumMember(Value = "UYU")]
    UYU,
    [EnumMember(Value = "PHP")]
    PHP,
    [EnumMember(Value = "DJF")]
    DJF,
    [EnumMember(Value = "XAF")]
    XAF,
    [EnumMember(Value = "XOF")]
    XOF,
    [EnumMember(Value = "HRK")]
    HRK,
    [EnumMember(Value = "CZK")]
    CZK,
    [EnumMember(Value = "CLP")]
    CLP,
    [EnumMember(Value = "LKR")]
    LKR,
    [EnumMember(Value = "EEK")]
    EEK,
    [EnumMember(Value = "ETB")]
    ETB,
    [EnumMember(Value = "RSD")]
    RSD,
    [EnumMember(Value = "ZAR")]
    ZAR,
    [EnumMember(Value = "KRW")]
    KRW,
    [EnumMember(Value = "NAD")]
    NAD,
    [EnumMember(Value = "TL")]
    TL,
    [EnumMember(Value = "UE")]
    UE
}