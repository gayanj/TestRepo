/*
 * Copyright 2005, 2008 PayPal, Inc. All Rights Reserved.
 *
 * DoDirectPayment SOAP example; last modified 08MAY23. 
 *
 * Process a credit card payment.  
 */
using System;
using com.paypal.sdk.services;
using com.paypal.soap.api;
using com.paypal.sdk.profiles;
/**
 * PayPal .NET SDK sample code
 */
namespace JB
{
    public class DoDirectPayment
    {
        public DoDirectPayment()
        {
        }
        public string DoDirectPaymentCode(string paymentAmount, string buyerLastName, string buyerFirstName, string buyerAddress1, string buyerAddress2, string buyerCity, string buyerState, string buyerZipCode, string creditCardType, string creditCardNumber, string CVV2, int expMonth, int expYear, PaymentActionCodeType paymentAction, string __apiusrname, string __apiusrpwd, string __apisign, string __env, string __ipaddr, string __mersessionid, string __cpayercountry)
        {
            CallerServices caller = new CallerServices();

            IAPIProfile profile = ProfileFactory.createSignatureAPIProfile();
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
            profile.APIUsername = __apiusrname;
            profile.APIPassword = __apiusrpwd;
            profile.APISignature = __apisign;
            profile.Environment = __env;
            caller.APIProfile = profile;

            // Create the request object.
            DoDirectPaymentRequestType pp_Request = new DoDirectPaymentRequestType();
            pp_Request.Version = "51.0";

            // Add request-specific fields to the request.
            // Create the request details object.
            pp_Request.DoDirectPaymentRequestDetails = new DoDirectPaymentRequestDetailsType();
            //pp_Request.DoDirectPaymentRequestDetails.IPAddress = "119.152.47.68";
            //pp_Request.DoDirectPaymentRequestDetails.MerchantSessionId = "1X911810264059026";
            pp_Request.DoDirectPaymentRequestDetails.IPAddress = __ipaddr;
            pp_Request.DoDirectPaymentRequestDetails.MerchantSessionId = __mersessionid;
            pp_Request.DoDirectPaymentRequestDetails.PaymentAction = paymentAction;

            pp_Request.DoDirectPaymentRequestDetails.CreditCard = new CreditCardDetailsType();
            pp_Request.DoDirectPaymentRequestDetails.CreditCard.CreditCardNumber = creditCardNumber;
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
            pp_Request.DoDirectPaymentRequestDetails.CreditCard.CVV2 = CVV2;
            pp_Request.DoDirectPaymentRequestDetails.CreditCard.ExpMonth = expMonth;
            pp_Request.DoDirectPaymentRequestDetails.CreditCard.ExpYear = expYear;
            pp_Request.DoDirectPaymentRequestDetails.CreditCard.ExpMonthSpecified = true;
            pp_Request.DoDirectPaymentRequestDetails.CreditCard.ExpYearSpecified = true;
            pp_Request.DoDirectPaymentRequestDetails.CreditCard.CardOwner = new PayerInfoType();
            pp_Request.DoDirectPaymentRequestDetails.CreditCard.CardOwner.Payer = "";
            pp_Request.DoDirectPaymentRequestDetails.CreditCard.CardOwner.PayerID = "";
            //pp_Request.DoDirectPaymentRequestDetails.CreditCard.CardOwner.PayerCountry = CountryCodeType.US;
            pp_Request.DoDirectPaymentRequestDetails.CreditCard.CardOwner.PayerStatus = PayPalUserStatusCodeType.unverified;
            
            switch (__cpayercountry)
            {
                case "USA":
                    pp_Request.DoDirectPaymentRequestDetails.CreditCard.CardOwner.PayerCountry = CountryCodeType.US;
                    break;
                case "GB":
                    pp_Request.DoDirectPaymentRequestDetails.CreditCard.CardOwner.PayerCountry = CountryCodeType.GB;
                    break;
                case "DE":
                    pp_Request.DoDirectPaymentRequestDetails.CreditCard.CardOwner.PayerCountry = CountryCodeType.DE;
                    break;
            }

            pp_Request.DoDirectPaymentRequestDetails.CreditCard.CardOwner.Address = new AddressType();
            pp_Request.DoDirectPaymentRequestDetails.CreditCard.CardOwner.Address.Street1 = buyerAddress1;
            pp_Request.DoDirectPaymentRequestDetails.CreditCard.CardOwner.Address.Street2 = buyerAddress2;
            pp_Request.DoDirectPaymentRequestDetails.CreditCard.CardOwner.Address.CityName = buyerCity;
            pp_Request.DoDirectPaymentRequestDetails.CreditCard.CardOwner.Address.StateOrProvince = buyerState;
            pp_Request.DoDirectPaymentRequestDetails.CreditCard.CardOwner.Address.PostalCode = buyerZipCode;
            
            switch (__cpayercountry)
            {
                case "USA":
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
            pp_Request.DoDirectPaymentRequestDetails.CreditCard.CardOwner.PayerName = new PersonNameType();
            pp_Request.DoDirectPaymentRequestDetails.CreditCard.CardOwner.PayerName.FirstName = buyerFirstName;
            pp_Request.DoDirectPaymentRequestDetails.CreditCard.CardOwner.PayerName.LastName = buyerLastName;
            pp_Request.DoDirectPaymentRequestDetails.PaymentDetails = new PaymentDetailsType();
            pp_Request.DoDirectPaymentRequestDetails.PaymentDetails.OrderTotal = new BasicAmountType();
            // NOTE: The only currency supported by the Direct Payment API at this time is US dollars (USD).
            
            switch (__cpayercountry)
            {
                case "USA":
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
            DoDirectPaymentResponseType pp_response = new DoDirectPaymentResponseType();
            pp_response = (DoDirectPaymentResponseType)caller.Call("DoDirectPayment", pp_Request);
            return pp_response.Ack.ToString();
        }
    }
}
