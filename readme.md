<a name='assembly'></a>
# OP-GenericDto

## Contents

- [Card](#T-OpenPath-Dto-Generic-Payment-Card 'OpenPath.Dto.Generic.Payment.Card')
  - [Bin](#P-OpenPath-Dto-Generic-Payment-Card-Bin 'OpenPath.Dto.Generic.Payment.Card.Bin')
  - [ExpirationMonth](#P-OpenPath-Dto-Generic-Payment-Card-ExpirationMonth 'OpenPath.Dto.Generic.Payment.Card.ExpirationMonth')
  - [ExpirationYear4Digit](#P-OpenPath-Dto-Generic-Payment-Card-ExpirationYear4Digit 'OpenPath.Dto.Generic.Payment.Card.ExpirationYear4Digit')
  - [MagneticTrack1](#P-OpenPath-Dto-Generic-Payment-Card-MagneticTrack1 'OpenPath.Dto.Generic.Payment.Card.MagneticTrack1')
  - [MagneticTrack2](#P-OpenPath-Dto-Generic-Payment-Card-MagneticTrack2 'OpenPath.Dto.Generic.Payment.Card.MagneticTrack2')
  - [MagneticTrack3](#P-OpenPath-Dto-Generic-Payment-Card-MagneticTrack3 'OpenPath.Dto.Generic.Payment.Card.MagneticTrack3')
  - [NameOnCard](#P-OpenPath-Dto-Generic-Payment-Card-NameOnCard 'OpenPath.Dto.Generic.Payment.Card.NameOnCard')
  - [Network](#P-OpenPath-Dto-Generic-Payment-Card-Network 'OpenPath.Dto.Generic.Payment.Card.Network')
  - [Number](#P-OpenPath-Dto-Generic-Payment-Card-Number 'OpenPath.Dto.Generic.Payment.Card.Number')
- [CardNetworkEnumerator](#T-OpenPath-Dto-Generic-Enumerator-CardNetworkEnumerator 'OpenPath.Dto.Generic.Enumerator.CardNetworkEnumerator')
- [CardNetworkExtension](#T-OpenPath-Dto-Generic-Extension-CardNetworkExtension 'OpenPath.Dto.Generic.Extension.CardNetworkExtension')
  - [ToCardNetworkEnumerator(network)](#M-OpenPath-Dto-Generic-Extension-CardNetworkExtension-ToCardNetworkEnumerator-System-String- 'OpenPath.Dto.Generic.Extension.CardNetworkExtension.ToCardNetworkEnumerator(System.String)')
  - [ToHuman(network)](#M-OpenPath-Dto-Generic-Extension-CardNetworkExtension-ToHuman-OpenPath-Dto-Generic-Enumerator-CardNetworkEnumerator- 'OpenPath.Dto.Generic.Extension.CardNetworkExtension.ToHuman(OpenPath.Dto.Generic.Enumerator.CardNetworkEnumerator)')

<a name='T-OpenPath-Dto-Generic-Payment-Card'></a>
## Card `type`

##### Namespace

OpenPath.Dto.Generic.Payment

##### Summary

A generic data object containing the standard data associated to the different types of
payment cards.

<a name='P-OpenPath-Dto-Generic-Payment-Card-Bin'></a>
### Bin `property`

##### Summary

A bank identification number (BIN) is the initial four to six numbers that appear on a
card. The bank identification number uniquely identifies the institution issuing the
card. The BIN is key in the process of matching transactions to the issuer of the
card. This numbering system applies to charge cards, gift cards, debit cards, prepaid
cards, and electronic benefit cards.

<a name='P-OpenPath-Dto-Generic-Payment-Card-ExpirationMonth'></a>
### ExpirationMonth `property`

##### Summary

A card expiration month tells you when the card is no longer valid along with the
expiration year. After a card expires, it shouldn't be usable, because the issuers
should deactivate the card when it reaches the expiration date.

<a name='P-OpenPath-Dto-Generic-Payment-Card-ExpirationYear4Digit'></a>
### ExpirationYear4Digit `property`

##### Summary

A card expiration year tells you when the card is no longer valid along with the
month year. After a card expires, it shouldn't be usable, because the issuers
should deactivate the card when it reaches the expiration date.

<a name='P-OpenPath-Dto-Generic-Payment-Card-MagneticTrack1'></a>
### MagneticTrack1 `property`

##### Summary

The first of three megnetic tracks on a card that typically contains encoded 
information about the cardholder's account, such as their card number, full name, the
card's expiration date and the country code.

<a name='P-OpenPath-Dto-Generic-Payment-Card-MagneticTrack2'></a>
### MagneticTrack2 `property`

##### Summary

The second of three megnetic tracks on a card that typically contains encoded 
information about the cardholder's account, such as their card number, full name, the
card's expiration date and the country code.

<a name='P-OpenPath-Dto-Generic-Payment-Card-MagneticTrack3'></a>
### MagneticTrack3 `property`

##### Summary

The third of three megnetic tracks on a card that typically contains any additional
encoded information from the issuer.

<a name='P-OpenPath-Dto-Generic-Payment-Card-NameOnCard'></a>
### NameOnCard `property`

##### Summary

This is the person authorized to use the card. That person didn’t necessarily open the
account, they might simply have permission to spend from the account as an "authorized
user."

<a name='P-OpenPath-Dto-Generic-Payment-Card-Network'></a>
### Network `property`

##### Summary

A card network are networks of issuing and acquiring banks through which payment cards
of some certain brand are processed.

<a name='P-OpenPath-Dto-Generic-Payment-Card-Number'></a>
### Number `property`

##### Summary

A card number is usually 15-16 digits long, but it could be as many as 19 digits or as
few as 13 in some cases. Each of these individual credit card numbers has meaning.

<a name='T-OpenPath-Dto-Generic-Enumerator-CardNetworkEnumerator'></a>
## CardNetworkEnumerator `type`

##### Namespace

OpenPath.Dto.Generic.Enumerator

##### Summary

A list of known network payment card types.

<a name='T-OpenPath-Dto-Generic-Extension-CardNetworkExtension'></a>
## CardNetworkExtension `type`

##### Namespace

OpenPath.Dto.Generic.Extension

##### Summary

An extension class for converting card networks to enumerators and to human readable text.

<a name='M-OpenPath-Dto-Generic-Extension-CardNetworkExtension-ToCardNetworkEnumerator-System-String-'></a>
### ToCardNetworkEnumerator(network) `method`

##### Summary

Converts the network name in a string to an enumerator. For example: Amex would be
converted to CardNetworkEnumerator.AmericanExpress.

##### Returns

The card network enumerator.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| network | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name of the network. |

<a name='M-OpenPath-Dto-Generic-Extension-CardNetworkExtension-ToHuman-OpenPath-Dto-Generic-Enumerator-CardNetworkEnumerator-'></a>
### ToHuman(network) `method`

##### Summary

Converts a card network enumerator to a human readable title cased string.

##### Returns

Returns a human readble string.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| network | [OpenPath.Dto.Generic.Enumerator.CardNetworkEnumerator](#T-OpenPath-Dto-Generic-Enumerator-CardNetworkEnumerator 'OpenPath.Dto.Generic.Enumerator.CardNetworkEnumerator') | The card network enumerator. |
