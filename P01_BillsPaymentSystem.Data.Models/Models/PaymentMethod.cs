using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using P01_BillsPaymentSystem.Data.Models.Enums;

namespace P01_BillsPaymentSystem.Data.Models
{
    [Table("PaymentMethods")]
    public class PaymentMethod
    {
        public PaymentMethod()
        {

        }
        public PaymentMethod(PaymentType type, int userId, int paymentTypeId)
        {
            this.Type = type;
            this.UserId = userId;
            if (type == PaymentType.BankAccount)
            {
                this.BankAccountId = paymentTypeId;
            }
            else
            {
                this.CreditCardId = paymentTypeId;
            }

        }
        public int Id { get; set; }
        public PaymentType Type { get; set; }
        public int UserId { get; set; }
        [ForeignKey(nameof(UserId))]
        public User User { get; set; }

        public int? BankAccountId { get; set; }
        public BankAccount BankAccount { get; set; }

        public int? CreditCardId { get; set; }
        public CreditCard CreditCard { get; set; }

    }
}