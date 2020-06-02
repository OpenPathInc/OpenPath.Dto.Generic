using Newtonsoft.Json;
using OpenPath.Dto.Generic.Enumerator;

namespace OpenPath.Dto.Generic.Payment {

    /// <summary>
    /// A generic data object containing the standard data associated to the different types of
    /// payment cards.
    /// </summary>
    public class Card {

        /// <summary>
        /// A bank identification number (BIN) is the initial four to six numbers that appear on a
        /// card. The bank identification number uniquely identifies the institution issuing the
        /// card. The BIN is key in the process of matching transactions to the issuer of the
        /// card. This numbering system applies to charge cards, gift cards, debit cards, prepaid
        /// cards, and electronic benefit cards.
        /// </summary>
        [JsonProperty("bin")]
        public int? Bin { get; set; }

        /// <summary>
        /// A card number is usually 15-16 digits long, but it could be as many as 19 digits or as
        /// few as 13 in some cases. Each of these individual credit card numbers has meaning.
        /// </summary>
        [JsonProperty("number")]
        public string Number { get; set; }

        /// <summary>
        /// A card expiration month tells you when the card is no longer valid along with the
        /// expiration year. After a card expires, it shouldn't be usable, because the issuers
        /// should deactivate the card when it reaches the expiration date.
        /// </summary>
        [JsonProperty("expiration_month")]
        public int ExpirationMonth { get; set; }

        /// <summary>
        /// A card expiration year tells you when the card is no longer valid along with the
        /// month year. After a card expires, it shouldn't be usable, because the issuers
        /// should deactivate the card when it reaches the expiration date.
        /// </summary>
        [JsonProperty("expiration_year_4_digit")]
        public int ExpirationYear4Digit { get; set; }

        /// <summary>
        /// This is the person authorized to use the card. That person didn’t necessarily open the
        /// account, they might simply have permission to spend from the account as an "authorized
        /// user."
        /// </summary>
        [JsonProperty("name_on_card")]
        public string NameOnCard { get; set; }

        /// <summary>
        /// The first of three megnetic tracks on a card that typically contains encoded 
        /// information about the cardholder's account, such as their card number, full name, the
        /// card's expiration date and the country code.
        /// </summary>
        [JsonProperty("magnetic_track_1")]
        public string MagneticTrack1 { get; set; }

        /// <summary>
        /// The second of three megnetic tracks on a card that typically contains encoded 
        /// information about the cardholder's account, such as their card number, full name, the
        /// card's expiration date and the country code.
        /// </summary>
        [JsonProperty("magnetic_track_2")]
        public string MagneticTrack2 { get; set; }

        /// <summary>
        /// The third of three megnetic tracks on a card that typically contains any additional
        /// encoded information from the issuer.
        /// </summary>
        [JsonProperty("magnetic_track_3")]
        public string MagneticTrack3 { get; set; }

        /// <summary>
        /// A card network are networks of issuing and acquiring banks through which payment cards
        /// of some certain brand are processed.
        /// </summary>
        [JsonProperty("network")]
        public CardNetworkEnumerator Network { get; set; }

    }

}
