using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InoivceApp_With_Entity.Domain.Entities
{
    public enum TypeOfCurrency
    {

        CAD,
        US,
        EUR
    }
    public class Invoice
    {
        /// <summary>
        /// Property for getting and setting the client name
        /// </summary>
        [Required(ErrorMessage = "Please enter the client name")]
        public string ClientName { get; set; }

        /// <summary>
        /// Property for getting and setting the clients address
        /// </summary>
        [Required(ErrorMessage = "Please enter the client address")]
        public string ClientAddress { get; set; }


        /// <summary>
        /// Property for getting and setting date of shipment
        /// </summary>
        [Required(ErrorMessage = "Please enter the date")]
        public DateTime DateOfShipment { get; set; }

        /// <summary>
        /// Property for getting and setting the payment due date
        /// </summary>
        [Required(ErrorMessage = "Please enter the date")]
        public DateTime PaymenDueDate { get; set; }

        /// <summary>
        /// Property for getting and setting the product name
        /// </summary>
        [Required(ErrorMessage = "Please enter the product name")]
        public string ProductName { get; set; }

        /// <summary>
        /// Property for getting and setting the product quantity
        /// </summary>
        [Required(ErrorMessage = "Please enter the product quantity")]
        public int ProductQuantity { get; set; }

        /// <summary>
        /// Property for getting and setting the unit price
        /// </summary>
        [Required(ErrorMessage = "Please enter the price of product")]
        public decimal UnitPrice { get; set; }

        /// <summary>
        /// Property for getting and setting the type of currency
        /// </summary>
        [Required(ErrorMessage = "Plase select a proper currency from the dropdown menu")]
        public TypeOfCurrency Currency { get; set; }

        /// <summary>
        /// Property for getting and setting the invoice number which gets generated each 
        /// time an invoice is made
        /// </summary>
        [Required]
        public int InoiceNumber { get; set; }
        [Required]
        public bool Paid { get; set; }

        /// <summary>
        /// Read-only property which calculates the total price for the product 
        /// without any taxes
        /// </summary>
        public decimal totalPriceForProduct
        {
            get { return UnitPrice * ProductQuantity; }
        }

        /// <summary>
        /// Read-only property which calculates the total price of the product
        /// including the 10% tax specified in the requirnments
        /// </summary>
        public decimal totalPrice
        {
            get { return totalPriceForProduct * 0.1m + totalPriceForProduct; }
        }

        public decimal totalTax
        {
            get { return totalPriceForProduct * 0.1m; }
        }
    }
}
