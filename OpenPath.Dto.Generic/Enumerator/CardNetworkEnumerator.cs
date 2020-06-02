using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace OpenPath.Dto.Generic.Enumerator {

    /// <summary>
    /// A list of known network payment card types.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))] 
    public enum CardNetworkEnumerator {

        [EnumMember(Value = "unknown")] Unknown = int.MinValue,
        [EnumMember(Value = "visa")] Visa = 100,
        [EnumMember(Value = "visa_ready_link")] VisaReadyLink = 101,
        [EnumMember(Value = "visa_debit")] VisaDebit = 102,
        [EnumMember(Value = "visa_electron")] VisaElectron = 103,
        [EnumMember(Value = "dankort")] Dankort = 104,
        [EnumMember(Value = "mastercard")] MasterCard = 200,
        [EnumMember(Value = "american_express")] AmericanExpress = 300,
        [EnumMember(Value = "discover")] Discover = 400,
        [EnumMember(Value = "diners_club")] DinersClub = 500,
        [EnumMember(Value = "rupay")] RuPay = 600,
        [EnumMember(Value = "interlink")] InterLink = 700,
        [EnumMember(Value = "star")] Star = 800,
        [EnumMember(Value = "accel")] Accel = 900,
        [EnumMember(Value = "interac")] Interac = 1000,        
        [EnumMember(Value = "pulse")] Pulse = 1100,
        [EnumMember(Value = "jcb")] Jcb = 1200,
        [EnumMember(Value = "maestro")] Maestro = 1300,
        [EnumMember(Value = "mondex")] Mondex = 1400,
        [EnumMember(Value = "cirrus")] Cirrus = 1500,
        [EnumMember(Value = "bancomat")] Bancomat = 1600,
        [EnumMember(Value = "bc_card")] BcCard = 1700,
        [EnumMember(Value = "bca_card")] BcaCard = 1800,
        [EnumMember(Value = "cabcharge")] Cabcharge = 1900,
        [EnumMember(Value = "eft_pos")] EftPos = 2000,
        [EnumMember(Value = "electronic_payment_service")] ElectronicPaymentServices = 2100,
        [EnumMember(Value = "elo")] Elo = 2200,
        [EnumMember(Value = "forbrugsforeningen")] Forbrugsforeningen = 2300,
        [EnumMember(Value = "girocard")] Girocard = 2400,
        [EnumMember(Value = "isracard")] Isracard = 2500,
        [EnumMember(Value = "mir")] Mir = 2600,
        [EnumMember(Value = "meps")] Meps = 2700,
        [EnumMember(Value = "mezza")] Meeza = 2800,
        [EnumMember(Value = "nets")] Nets = 2900,
        [EnumMember(Value = "pay_pak")] PayPak = 3000,
        [EnumMember(Value = "troy")] Troy  = 3100,
        [EnumMember(Value = "union_pay")] UnionPay = 3200,
        [EnumMember(Value = "uatpo")] Uatp = 3300,
        [EnumMember(Value = "v_pay")] VPay = 3400,
        [EnumMember(Value = "verve")] Verve = 3500,
        [EnumMember(Value = "access")] Access = 3600,
        [EnumMember(Value = "bankcard")] Bankcard = 3700,
        [EnumMember(Value = "carte_blanche")] CarteBlanche = 3800,
        [EnumMember(Value = "carte_bleue")] CarteBleue = 3900,
        [EnumMember(Value = "choice")] Choice = 4000,
        [EnumMember(Value = "enroute")] enRoute = 4100,
        [EnumMember(Value = "eurocard")] Eurocard = 4200,
        [EnumMember(Value = "everything")] Everything = 4300,
        [EnumMember(Value = "laser")] Laser = 4400,
        [EnumMember(Value = "rail_travel_card")] RailTravelCard = 4500,
        [EnumMember(Value = "revolution_card")] RevolutionCard = 4600,
        [EnumMember(Value = "solo")] Solo = 4700,
        [EnumMember(Value = "switch")] Switch = 4800,
        [EnumMember(Value = "pin")] Pin = 4900,
        [EnumMember(Value = "other")] Other = int.MaxValue

    }

}