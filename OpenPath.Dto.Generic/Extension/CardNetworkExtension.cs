using OpenPath.Dto.Generic.Enumerator;
using OpenPath.Utility.Parser;

namespace OpenPath.Dto.Generic.Extension {

    /// <summary>
    /// An extension class for converting card networks to enumerators and to human readable text.
    /// </summary>
    public static class CardNetworkExtension {

        /// <summary>
        /// Converts the network name in a string to an enumerator. For example: Amex would be
        /// converted to CardNetworkEnumerator.AmericanExpress.
        /// </summary>
        /// <param name="network">The name of the network.</param>
        /// <returns>The card network enumerator.</returns>
        public static CardNetworkEnumerator ToCardNetworkEnumerator(this string network) {

            // validate
            if(network == null) return CardNetworkEnumerator.Unknown;

            // set the default result
            var result = CardNetworkEnumerator.Unknown;

            // clean the networkstring
            var cleanedNetwork = network
                .Replace("-", string.Empty)
                .Replace(" ", string.Empty)
                .Replace("_", string.Empty)
                .Replace(".", string.Empty)
                .ToLower();

            // equals
            if(cleanedNetwork == "visa" && result == CardNetworkEnumerator.Unknown) result = CardNetworkEnumerator.Visa;
            if(cleanedNetwork == "electron" && result == CardNetworkEnumerator.Unknown) result = CardNetworkEnumerator.VisaElectron;
            if(cleanedNetwork == "eps" && result == CardNetworkEnumerator.Unknown) result = CardNetworkEnumerator.ElectronicPaymentServices;
            if(cleanedNetwork == "mir" && result == CardNetworkEnumerator.Unknown) result = CardNetworkEnumerator.Mir;
            
            // contains
            if(cleanedNetwork.Contains("amex") && result == CardNetworkEnumerator.Unknown) result = CardNetworkEnumerator.AmericanExpress;
            if(cleanedNetwork.Contains("discover") && result == CardNetworkEnumerator.Unknown) result = CardNetworkEnumerator.Discover;
            if(cleanedNetwork.Contains("rupay") && result == CardNetworkEnumerator.Unknown) result = CardNetworkEnumerator.RuPay;
            if(cleanedNetwork.Contains("interlink") && result == CardNetworkEnumerator.Unknown) result = CardNetworkEnumerator.InterLink;
            if(cleanedNetwork.Contains("interac") && result == CardNetworkEnumerator.Unknown) result = CardNetworkEnumerator.Interac;
            if(cleanedNetwork.Contains("visadebit") && result == CardNetworkEnumerator.Unknown) result = CardNetworkEnumerator.VisaDebit;
            if(cleanedNetwork.Contains("visaelectron") && result == CardNetworkEnumerator.Unknown) result = CardNetworkEnumerator.VisaElectron;
            if(cleanedNetwork.Contains("master") && result == CardNetworkEnumerator.Unknown) result = CardNetworkEnumerator.MasterCard;
            if(cleanedNetwork.Contains("american") && result == CardNetworkEnumerator.Unknown) result = CardNetworkEnumerator.AmericanExpress;
            if(cleanedNetwork.Contains("express") && result == CardNetworkEnumerator.Unknown) result = CardNetworkEnumerator.AmericanExpress;
            if(cleanedNetwork.Contains("diner") && result == CardNetworkEnumerator.Unknown) result = CardNetworkEnumerator.DinersClub;
            if(cleanedNetwork.Contains("star") && result == CardNetworkEnumerator.Unknown) result = CardNetworkEnumerator.Star;
            if(cleanedNetwork.Contains("accel") && result == CardNetworkEnumerator.Unknown) result = CardNetworkEnumerator.Accel;
            if(cleanedNetwork.Contains("ready") && result == CardNetworkEnumerator.Unknown) result = CardNetworkEnumerator.VisaReadyLink;
            if(cleanedNetwork.Contains("pulse") && result == CardNetworkEnumerator.Unknown) result = CardNetworkEnumerator.Pulse;
            if(cleanedNetwork.Contains("jcb") && result == CardNetworkEnumerator.Unknown) result = CardNetworkEnumerator.Jcb;
            if(cleanedNetwork.Contains("maestro") && result == CardNetworkEnumerator.Unknown) result = CardNetworkEnumerator.Maestro;
            if(cleanedNetwork.Contains("bancomat") && result == CardNetworkEnumerator.Unknown) result = CardNetworkEnumerator.Bancomat;
            if(cleanedNetwork.Contains("bccard") && result == CardNetworkEnumerator.Unknown) result = CardNetworkEnumerator.BcCard;
            if(cleanedNetwork.Contains("bcacard") && result == CardNetworkEnumerator.Unknown) result = CardNetworkEnumerator.BcaCard;
            if(cleanedNetwork.Contains("cabcharge") && result == CardNetworkEnumerator.Unknown) result = CardNetworkEnumerator.Cabcharge;
            if(cleanedNetwork.Contains("dankort") && result == CardNetworkEnumerator.Unknown) result = CardNetworkEnumerator.Dankort;
            if(cleanedNetwork.Contains("eftpos") && result == CardNetworkEnumerator.Unknown) result = CardNetworkEnumerator.EftPos;
            if(cleanedNetwork.Contains("electronicpaymentservice") && result == CardNetworkEnumerator.Unknown) result = CardNetworkEnumerator.ElectronicPaymentServices;
            if(cleanedNetwork.Contains("electronic") && result == CardNetworkEnumerator.Unknown) result = CardNetworkEnumerator.ElectronicPaymentServices;
            if(cleanedNetwork.Contains("elo") && result == CardNetworkEnumerator.Unknown) result = CardNetworkEnumerator.Elo;
            if(cleanedNetwork.Contains("forbrugsforeningen") && result == CardNetworkEnumerator.Unknown) result = CardNetworkEnumerator.Forbrugsforeningen;
            if(cleanedNetwork.Contains("giro") && result == CardNetworkEnumerator.Unknown) result = CardNetworkEnumerator.Girocard;
            if(cleanedNetwork.Contains("isra") && result == CardNetworkEnumerator.Unknown) result = CardNetworkEnumerator.Isracard;
            if(cleanedNetwork.Contains("meps") && result == CardNetworkEnumerator.Unknown) result = CardNetworkEnumerator.Meps;
            if(cleanedNetwork.Contains("meeza") && result == CardNetworkEnumerator.Unknown) result = CardNetworkEnumerator.Meeza;
            if(cleanedNetwork.Contains("nets") && result == CardNetworkEnumerator.Unknown) result = CardNetworkEnumerator.Nets;
            if(cleanedNetwork.Contains("troy") && result == CardNetworkEnumerator.Unknown) result = CardNetworkEnumerator.Troy;
            if(cleanedNetwork.Contains("union") && result == CardNetworkEnumerator.Unknown) result = CardNetworkEnumerator.UnionPay;
            if(cleanedNetwork.Contains("uatp") && result == CardNetworkEnumerator.Unknown) result = CardNetworkEnumerator.Uatp;
            if(cleanedNetwork.Contains("vpay") && result == CardNetworkEnumerator.Unknown) result = CardNetworkEnumerator.VPay;
            if(cleanedNetwork.Contains("verve") && result == CardNetworkEnumerator.Unknown) result = CardNetworkEnumerator.Verve;
            if(cleanedNetwork.Contains("access") && result == CardNetworkEnumerator.Unknown) result = CardNetworkEnumerator.Access;
            if(cleanedNetwork.Contains("bankcard") && result == CardNetworkEnumerator.Unknown) result = CardNetworkEnumerator.Bankcard;
            if(cleanedNetwork.Contains("blanche") && result == CardNetworkEnumerator.Unknown) result = CardNetworkEnumerator.CarteBlanche;
            if(cleanedNetwork.Contains("bleue") && result == CardNetworkEnumerator.Unknown) result = CardNetworkEnumerator.CarteBleue;
            if(cleanedNetwork.Contains("choice") && result == CardNetworkEnumerator.Unknown) result = CardNetworkEnumerator.Choice;
            if(cleanedNetwork.Contains("route") && result == CardNetworkEnumerator.Unknown) result = CardNetworkEnumerator.enRoute;
            if(cleanedNetwork.Contains("everything") && result == CardNetworkEnumerator.Unknown) result = CardNetworkEnumerator.Everything;
            if(cleanedNetwork.Contains("rail") && result == CardNetworkEnumerator.Unknown) result = CardNetworkEnumerator.RailTravelCard;
            if(cleanedNetwork.Contains("travel") && result == CardNetworkEnumerator.Unknown) result = CardNetworkEnumerator.RailTravelCard;
            if(cleanedNetwork.Contains("revolution") && result == CardNetworkEnumerator.Unknown) result = CardNetworkEnumerator.RevolutionCard;
            if(cleanedNetwork.Contains("solo") && result == CardNetworkEnumerator.Unknown) result = CardNetworkEnumerator.Solo;
            if(cleanedNetwork.Contains("switch") && result == CardNetworkEnumerator.Unknown) result = CardNetworkEnumerator.Switch;
            if(cleanedNetwork.Contains("pin") && result == CardNetworkEnumerator.Unknown) result = CardNetworkEnumerator.Pin;;

            return result;

        }

        /// <summary>
        /// Converts a card network enumerator to a human readable title cased string.
        /// </summary>
        /// <param name="network">The card network enumerator.</param>
        /// <returns>Returns a human readble string.</returns>
        public static string ToHuman(this CardNetworkEnumerator network) {

            switch(network) {

                // manual conversion of the outliers 
                case CardNetworkEnumerator.BcaCard: return "BCA Card";
                case CardNetworkEnumerator.BcCard: return "BC Card";
                case CardNetworkEnumerator.EftPos: return "EFT POS";
                case CardNetworkEnumerator.enRoute: return "enRoute";
                case CardNetworkEnumerator.Uatp: return CardNetworkEnumerator.Uatp.ToString().ToUpper();
                case CardNetworkEnumerator.VPay: return "VPay";

                // auto conversion
                default: return network.ToString().ToSentenceCase().ToTitleCase();

            };

        }

    }

}
