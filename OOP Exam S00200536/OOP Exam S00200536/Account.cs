/*###########################################################################################################################
 Name: Abigail Herron
 ID: S00200536
 Year: 2
 Date: 11/01/21
 GitHub Repository Link: https://github.com/AbigailHerron/OOP-Exam
 Description: Contains the Account, CurrentAccount and SavingsAccount Classes
            
                ACCOUNT CLASS (abstract class)
 Properties: AccountNumber, FirstName, LastName, InterestDate, Balance
 Methods: Deposit, Withdraw, ToString (override), CalculateInterest (abstract)

                CURRENT_ACCOUNT CLASS
 Additional Properties: InterestRate
 Additional/Modified Methods: CalculateInterest
 Constructors: Default

                SAVINGS_ACCOUNT CLASS
 Additional Properties: InterestRate
 Additional/Modified Methods: CalculateInterest
 Constructors: Default
 ##########################################################################################################################*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exam_S00200536
{

    /*############################################## ACCOUNT CLASS ###############################################*/
    abstract class Account
    {

        /*PROPERTIES ------------------------------------------------------------------------------------------------------*/
        public string AccountNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string InterestDate { get; set; }
        public decimal Balance { get; set; }


        /*METHODS ---------------------------------------------------------------------------------------------------------*/
        /*Method: Deposit()
                  1) Takes in a decimal value
                  2) Adds value to the Balance property */        
        public void Deposit(decimal ammount)
        {
            this.Balance += ammount;
        }// end Deposit()

        /*Method: Withdraw()
                  1) Takes in a decimal value
                  2) Removes value to the Balance property */
        public void Withdraw(decimal ammount)
        {
            this.Balance -= ammount;
        }// end Withdraw()

        /*Method: ToString()
                  1) Overrides original ToString method
                  2) Displays the Account number - LastName, FirstName of 
                     object in that order */
        public override string ToString()
        {
            return $"{this.AccountNumber} - {this.LastName}, {this.FirstName}";
        }// end ToString()


        /*Method: CalculateInterest()
                  1) To be modified by any subclasses */
        abstract public decimal CalculateInterest();
    }// end Account Class



    /*########################################## CURRENT_ACCOUNT CLASS ##########################################*/

    class CurrentAccount : Account
    {
        /*ADDITIONAL PROPERTIES -------------------------------------------------------------------------------------------*/
        public double InterestRate = 0.03;


        /*METHODS ---------------------------------------------------------------------------------------------------------*/
        /*Method: CalculateInterest()
                  1) */
        public override decimal CalculateInterest()
        {
            decimal rate = 0m;
            DateTime today = DateTime.Now;
            DateTime thisYear = new DateTime(01/01/2021);

            if (today >= thisYear)
            {
                rate = this.Balance * (decimal)this.InterestRate;
            }
            return rate;
        }// end CalculateInterest()

    }// end CurrentAccount Class





    /*########################################## SAVINGS_ACCOUNT CLASS ##########################################*/
    class SavingsAccount : Account
    {
        /*ADDITIONAL PROPERTIES -------------------------------------------------------------------------------------------*/
        public double InterestRate = 0.06;


        /*METHODS ---------------------------------------------------------------------------------------------------------*/
        /*Method: CalculateInterest()
                  1) */
        public override decimal CalculateInterest()
        {
            decimal rate = 0m;
            DateTime today = DateTime.Now;
            DateTime thisYear = new DateTime(01 / 01 / 2021);

            if (today >= thisYear)
            {
                rate = this.Balance * (decimal)this.InterestRate;
            }
            return rate;
        }// end CalculateInterest()

    }// end SavingsAccount Class

}// end Namespace
