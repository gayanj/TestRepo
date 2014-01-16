using com.paypal.sdk.profiles;
using com.paypal.sdk.services;
using com.paypal.soap.api;

/*
 * Copyright 2005, 2008 PayPal, Inc. All Rights Reserved.
 *
 * DoDirectPayment SOAP example; last modified 08MAY23.
 *
 * Process a credit card payment.
 */

/**
 * PayPal .NET SDK sample code
 */

namespace Msftlayer
{
    public class ClDoDirectPayment
    {
        public string DoDirectPaymentCode(string paymentAmount, string buyerLastName, string buyerFirstName,
                                          string buyerAddress1, string buyerAddress2, string buyerCity,
                                          string buyerState, string buyerZipCode, string creditCardType,
                                          string creditCardNumber, string cvv2, int expMonth, int expYear,
                                          string apiusrname, string apiusrpwd, string apisign, string env,
                                          string ipaddr, string mersessionid, string cpayercountry)
        {
            var caller = new CallerServices();
            var profile = ProfileFactory.createSignatureAPIProfile();
            /*
             WARNING: Do not embed plaintext credentials in your application code.
             Doing so is insecure and against best practices.
             Your API credentials must be handled securely. Please consider
             encrypting them for use in any production environment, and ensure
             that only authorized individuals may view or modify them.
             */

            // Set up your API credentials, PayPal end point, and API version.
            //profile.APIUsername = "moni._1324665158_biz_api1.data-it.co.uk";
            //profile.APIPassword = "1324665194";
            //profile.APISignature = "A04204hfWDnDasn73H4zXWvoqhWKARiFQxHdAcoUTHj3RjC.VMn96sHi";
            //profile.Environment = "sandbox";
            //caller.APIProfile = profile;
            var paymentAction = PaymentActionCodeType.Sale;
            profile.APIUsername = apiusrname;
            profile.APIPassword = apiusrpwd;
            profile.APISignature = apisign;
            profile.Environment = env;
            caller.APIProfile = profile;

            // Create the request object.
            var pp_Request = new DoDirectPaymentRequestType
                                 {
                                     Version = "51.0",
                                     DoDirectPaymentRequestDetails =
                                         new DoDirectPaymentRequestDetailsType
                                             {
                                                 IPAddress = ipaddr,
                                                 MerchantSessionId = mersessionid,
                                                 PaymentAction = paymentAction,
                                                 CreditCard =
                                                     new CreditCardDetailsType { CreditCardNumber = creditCardNumber }
                                             }
                                 };

            // Add request-specific fields to the request.
            // Create the request details object.
            //pp_Request.DoDirectPaymentRequestDetails.IPAddress = "119.152.47.68";
            //pp_Request.DoDirectPaymentRequestDetails.MerchantSessionId = "1X911810264059026";

            switch (creditCardType)
            {
                case "Visa":
                    pp_Request.DoDirectPaymentRequestDetails.CreditCard.CreditCardType = CreditCardTypeType.Visa;
                    break;
                case "MasterCard":
                    pp_Request.DoDirectPaymentRequestDetails.CreditCard.CreditCardType = CreditCardTypeType.MasterCard;
                    break;
                case "Discover":
                    pp_Request.DoDirectPaymentRequestDetails.CreditCard.CreditCardType = CreditCardTypeType.Discover;
                    break;
                case "Amex":
                    pp_Request.DoDirectPaymentRequestDetails.CreditCard.CreditCardType = CreditCardTypeType.Amex;
                    break;
            }
            pp_Request.DoDirectPaymentRequestDetails.CreditCard.CVV2 = cvv2;
            pp_Request.DoDirectPaymentRequestDetails.CreditCard.ExpMonth = expMonth;
            pp_Request.DoDirectPaymentRequestDetails.CreditCard.ExpYear = expYear;
            pp_Request.DoDirectPaymentRequestDetails.CreditCard.ExpMonthSpecified = true;
            pp_Request.DoDirectPaymentRequestDetails.CreditCard.ExpYearSpecified = true;
            pp_Request.DoDirectPaymentRequestDetails.CreditCard.CardOwner = new PayerInfoType
                                                                                {
                                                                                    Payer = "",
                                                                                    PayerID = "",
                                                                                    PayerStatus =
                                                                                        PayPalUserStatusCodeType.
                                                                                        unverified
                                                                                };
            //pp_Request.DoDirectPaymentRequestDetails.CreditCard.CardOwner.PayerCountry = CountryCodeType.US;

            switch (cpayercountry)
            {
                case "US":
                    pp_Request.DoDirectPaymentRequestDetails.CreditCard.CardOwner.PayerCountry = CountryCodeType.US;
                    break;
                case "GB":
                    pp_Request.DoDirectPaymentRequestDetails.CreditCard.CardOwner.PayerCountry = CountryCodeType.GB;
                    break;
                case "DE":
                    pp_Request.DoDirectPaymentRequestDetails.CreditCard.CardOwner.PayerCountry = CountryCodeType.DE;
                    break;
            }

            pp_Request.DoDirectPaymentRequestDetails.CreditCard.CardOwner.Address = new AddressType
                                                                                        {
                                                                                            Street1 = buyerAddress1,
                                                                                            Street2 = buyerAddress2,
                                                                                            CityName = buyerCity,
                                                                                            StateOrProvince = buyerState,
                                                                                            PostalCode = buyerZipCode
                                                                                        };

            switch (cpayercountry)
            {
                case "US":
                    pp_Request.DoDirectPaymentRequestDetails.CreditCard.CardOwner.Address.CountryName = "USA";
                    pp_Request.DoDirectPaymentRequestDetails.CreditCard.CardOwner.Address.Country = CountryCodeType.US;
                    break;
                case "GB":
                    pp_Request.DoDirectPaymentRequestDetails.CreditCard.CardOwner.Address.CountryName = "GB";
                    pp_Request.DoDirectPaymentRequestDetails.CreditCard.CardOwner.Address.Country = CountryCodeType.GB;
                    break;
                case "DE":
                    pp_Request.DoDirectPaymentRequestDetails.CreditCard.CardOwner.Address.CountryName = "DE";
                    pp_Request.DoDirectPaymentRequestDetails.CreditCard.CardOwner.Address.Country = CountryCodeType.DE;
                    break;
            }

            pp_Request.DoDirectPaymentRequestDetails.CreditCard.CardOwner.Address.CountrySpecified = true;
            pp_Request.DoDirectPaymentRequestDetails.CreditCard.CardOwner.PayerName = new PersonNameType
                                                                                          {
                                                                                              FirstName = buyerFirstName,
                                                                                              LastName = buyerLastName
                                                                                          };
            pp_Request.DoDirectPaymentRequestDetails.PaymentDetails = new PaymentDetailsType { OrderTotal = new BasicAmountType() };
            // NOTE: The only currency supported by the Direct Payment API at this time is US dollars (USD).

            switch (cpayercountry)
            {
                case "US":
                    pp_Request.DoDirectPaymentRequestDetails.PaymentDetails.OrderTotal.currencyID = CurrencyCodeType.USD;
                    break;
                case "GB":
                    pp_Request.DoDirectPaymentRequestDetails.PaymentDetails.OrderTotal.currencyID = CurrencyCodeType.GBP;
                    break;
                case "DE":
                    pp_Request.DoDirectPaymentRequestDetails.PaymentDetails.OrderTotal.currencyID = CurrencyCodeType.EUR;
                    break;
            }

            pp_Request.DoDirectPaymentRequestDetails.PaymentDetails.OrderTotal.Value = paymentAmount;

            // Execute the API operation and obtain the response.
            var pp_response = new DoDirectPaymentResponseType();
            pp_response = (DoDirectPaymentResponseType)caller.Call("DoDirectPayment", pp_Request);
            return pp_response.Ack.ToString();
        }
    }
}