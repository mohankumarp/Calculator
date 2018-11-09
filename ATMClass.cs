using System;
using System.Collections;
using System.Collections.Generic;

/*
Console.WriteLine("********Welcome to ATM Service**************\n");
                    Console.WriteLine("1. Check Balance\n");
                    Console.WriteLine("2. Withdraw Cash\n");
                    Console.WriteLine("3. Deposit Cash\n");
                    Console.WriteLine("4. Quit\n");
                    Console.WriteLine("*********************************************\n\n");

    */

namespace com.vm
{
    public class ATMClass
    {

      public enum StatusCode : int
        {
            SUCCESS = 0,
            INVALID_PIN = 1,
            INVALID_CHOICE = 2,
            INVALID_DENOMINATION = 3,
            INSUFFICIENT_BALANCE = 4,
            INVALID_DEPOSIT_AMOUNT = 5,
            QUIT = 9,
            ERROR = -1,
        };


        public static StatusCode Transaction(int pin, int trans_code, int amount)
        {
            int balance = 1000, deposit, withdraw;
            StatusCode status = StatusCode.SUCCESS;
            var result = 0;
            Boolean flag = true;

            if (pin == 3551)
            {
                while (flag)
                {
                    switch (trans_code)
                    {
                        case 1:
                            result = balance;
                            flag = false;
                            break;
                        case 2:
                            withdraw = amount;
                            if (withdraw % 100 != 0)
                            {
                                result = 0;
                                status = StatusCode.INVALID_DENOMINATION;
                            }
                            else if (withdraw > (balance - 500))
                            {
                                result = 0;
                                status = StatusCode.INSUFFICIENT_BALANCE;
                            }
                            else
                            {
                                balance = balance - withdraw;
                                result = balance;
                            }
                            flag = false;
                            break;
                        case 3:
                            
                            deposit = amount;
                            if (deposit < 0)
                            {
                                result = 0;
                                status = StatusCode.INVALID_DEPOSIT_AMOUNT;
                                break;
                            }
                            else
                            {
                                balance = balance + deposit;
                                result = balance;
                            }
                            flag = false;
                            break;
                        case 4:
                            status = StatusCode.QUIT;
                            flag = false;
                            break;
                        default:
                            status = StatusCode.INVALID_CHOICE;
                            break;
                    }
                }
            }
            else
            {
                status = StatusCode.INVALID_PIN;
            }

            return status;
        }
    }
}
