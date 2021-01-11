/*###########################################################################################################################
 Name: Abigail Herron
 ID: S00200536
 Year: 2
 Date: 11/01/21
 GitHub Repository Link: https://github.com/AbigailHerron/OOP-Exam
 Description: Contains the Account, CurrentAccount and SavingsAccount Classes
            
                ACCOUNT CLASS (abstract class)
 Properties:
 Methods:

                CURRENT_ACCOUNT CLASS
 Properties:
 Methods:
 Constructors: Default

                SAVINGS_ACCOUNT CLASS
 Properties:
 Methods:
 Constructors: Default
 ##########################################################################################################################*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exam_S00200536
{
    abstract class Account
    {

        /*PROPERTIES ------------------------------------------------------------------------------------------------------*/
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


        /*Method: CalculateInterest()
                  1) To be modified by any subclasses */
        abstract public void CalculateInterest();
    }// end Account Class



}// end Namespace
